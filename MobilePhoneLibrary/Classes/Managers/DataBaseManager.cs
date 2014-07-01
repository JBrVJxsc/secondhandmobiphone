using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MobilePhoneLibrary.Classes.Enums;
using MobilePhoneLibrary.Classes.Objects;
using MobilePhoneLoader.Class.Managers;

namespace MobilePhoneLibrary.Classes.Managers
{
    public class DataBaseManager
    {
        private string dataBaseUrl = "Db.mdb";
        private string dataBaseUser = "Admin";
        private string dataBasePassword = "who";
        public static readonly string connectionStringBase = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=false;";
        public static OleDbConnection connectionOfDataBase = null;
        public static DataBaseManager GlobalDataBaseManager = new DataBaseManager();

        public DataBaseManager()
        {
            try
            {
                string connectionString = string.Empty;
                if (connectionOfDataBase == null)
                {
                    connectionString = connectionStringBase;
                    connectionString += "Data Source=" + dataBaseUrl + ";";
                    connectionString += "User ID=" + dataBaseUser + ";";
                    connectionString += "Jet OLEDB:Database Password=" + dataBasePassword + ";";
                    connectionOfDataBase = new OleDbConnection(connectionString);
                    connectionOfDataBase.Open();
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("建立数据库连接出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenDataBase()
        {
            try
            {
                if (connectionOfDataBase != null)
                {
                    if (connectionOfDataBase.State != ConnectionState.Open)
                    {
                        connectionOfDataBase.Open();
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("打开数据库出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseDataBase()
        {
            try
            {
                if (connectionOfDataBase != null)
                {
                    if (connectionOfDataBase.State != ConnectionState.Closed)
                    {
                        connectionOfDataBase.Close();
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("关闭数据库出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ExecuteNonQuery(OleDbConnection connection, string commandString, params OleDbParameter[] commandParameters)
        {
            OleDbCommand command = new OleDbCommand();
            PrepareCommand(command, connection, null, commandString, commandParameters);
            int result = command.ExecuteNonQuery();
            command.Parameters.Clear();
            return result;
        }

        private int ExecuteNonQuery(OleDbTransaction transaction, string commandString, params OleDbParameter[] commandParameters)
        {
            OleDbCommand command = new OleDbCommand();
            PrepareCommand(command, transaction.Connection, transaction, commandString, commandParameters);
            int result = command.ExecuteNonQuery();
            command.Parameters.Clear();
            return result;
        }

        private OleDbDataReader ExecuteReader(OleDbConnection connection, string commandString, params OleDbParameter[] commandParameters)
        {
            OleDbCommand command = new OleDbCommand();
            PrepareCommand(command, connection, null, commandString, commandParameters);
            OleDbDataReader reader = command.ExecuteReader();
            command.Parameters.Clear();
            return reader;
        }

        public DataSet ExecuteDataSet(OleDbConnection connection, string commandString, params OleDbParameter[] commandParameters)
        {
            OleDbCommand command = new OleDbCommand();
            PrepareCommand(command, connection, null, commandString, commandParameters);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            command.Parameters.Clear();
            return dataSet;
        }

        private void PrepareCommand(OleDbCommand command, OleDbConnection connection, OleDbTransaction transaction, string commandString, OleDbParameter[] commandParameters)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            command.Connection = connection;
            command.CommandText = commandString;
            if (transaction != null)
            {
                command.Transaction = transaction;
            }
            command.CommandType = System.Data.CommandType.Text;
            if (commandParameters != null)
            {
                foreach (OleDbParameter parameter in commandParameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
        }

        private void InsertBrand(BrandObject brandObject)
        {
            try
            {
                string sql = global::MobilePhoneLibrary.Properties.Resources.SQL_Insert_Brand;
                OleDbParameter parameter0 = new OleDbParameter("@EnglishName", brandObject.EnglishName);
                OleDbParameter parameter1 = new OleDbParameter("@ChineseName", brandObject.ChineseName);
                OleDbParameter parameter2 = new OleDbParameter("@SortID", brandObject.SortID.ToString());
                ExecuteNonQuery(connectionOfDataBase, sql, parameter0, parameter1, parameter2);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("将品牌插入数据库出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertModel(ModelObject modelObject)
        {
            try
            {
                string sql = global::MobilePhoneLibrary.Properties.Resources.SQL_Insert_Model;
                OleDbParameter parameter0 = new OleDbParameter("@BrandEnglishName", modelObject.BrandEnglishName);
                OleDbParameter parameter1 = new OleDbParameter("@ModelName", modelObject.ModelName);
                OleDbParameter parameter2 = new OleDbParameter("@SortID", modelObject.SortID.ToString());
                ExecuteNonQuery(connectionOfDataBase, sql, parameter0, parameter1, parameter2);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("将型号插入数据库出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SortedList QueryAllBrand()
        {
            OleDbDataReader reader = null;
            SortedList brandList = null;
            try
            {
                string sql = global::MobilePhoneLibrary.Properties.Resources.SQL_Select_Brand;
                reader = ExecuteReader(connectionOfDataBase, sql, null);
                brandList = new SortedList();
                while (reader.Read())
                {
                    BrandObject brand = new BrandObject();
                    brand.EnglishName = reader["EnglishName"].ToString();
                    brand.ChineseName = reader["ChineseName"].ToString();
                    brand.SortID = Convert.ToInt32(reader["SortID"]);
                    brandList.Add(brand, null);
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("获取品牌信息出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return brandList;
        }

        public SortedList QueryModelByBrandEnglishName(string brandEnglishName)
        {
            OleDbDataReader reader = null;
            SortedList modelList = null;
            try
            {
                string sql = global::MobilePhoneLibrary.Properties.Resources.SQL_Select_Model_By_BrandEnglishName;
                OleDbParameter parameter0 = new OleDbParameter("@BrandEnglishName", brandEnglishName);
                reader = ExecuteReader(connectionOfDataBase, sql, parameter0);
                modelList = new SortedList();
                while (reader.Read())
                {
                    ModelObject model = new ModelObject();
                    model.BrandEnglishName = reader["BrandEnglishName"].ToString();
                    model.ModelName = reader["ModelName"].ToString();
                    model.SortID = Convert.ToInt32(reader["SortID"]);
                    modelList.Add(model, null);
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("获取型号信息出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return modelList;
        }

        public List<TradeObject> QueryTrade(int number, TradeType tradeType)
        {
            OleDbDataReader reader = null;
            List<TradeObject> tradeObjectList = null;
            try
            {
                string sql = global::MobilePhoneLibrary.Properties.Resources.SQL_Select_Trade_By_Top_And_TradeType;
                sql =string.Format(sql,number);
                OleDbParameter parameter0 = new OleDbParameter("@TradeType", tradeType.ToString());
                reader = ExecuteReader(connectionOfDataBase, sql, parameter0);
                tradeObjectList = new List<TradeObject>();
                while (reader.Read())
                {
                    TradeObject tradeObject = new TradeObject();
                    tradeObject.TradeID = reader["TradeID"].ToString();
                    tradeObject.TradeType = tradeType;
                    tradeObject.PersonName = reader["PersonName"].ToString();
                    tradeObject.PersonID = reader["PersonID"].ToString();
                    tradeObject.PersonPhoneNumber = reader["PersonPhoneNumber"].ToString();
                    tradeObject.Brand = reader["Brand"].ToString();
                    tradeObject.Model = reader["Model"].ToString();
                    tradeObject.PhoneColor = reader["PhoneColor"].ToString();
                    tradeObject.Price = Convert.ToDecimal(reader["Price"]);
                    tradeObject.IMEI = reader["IMEI"].ToString();
                    tradeObject.OperName = reader["OperName"].ToString();
                    tradeObject.OperDate = Convert.ToDateTime(reader["OperDate"]);
                    tradeObject.SendToServer = Convert.ToBoolean(reader["SendToServer"]);
                    tradeObjectList.Add(tradeObject);
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("获取记录出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return tradeObjectList;
        }

        public List<TradeObject> QueryUnsendedTrade()
        {
            OleDbDataReader reader = null;
            List<TradeObject> tradeObjectList = null;
            try
            {
                string sql = global::MobilePhoneLibrary.Properties.Resources.SQL_Select_Unsended_Trade;
                reader = ExecuteReader(connectionOfDataBase, sql, null);
                tradeObjectList = new List<TradeObject>();
                while (reader.Read())
                {
                    TradeObject tradeObject = new TradeObject();
                    tradeObject.TradeID = reader["TradeID"].ToString();
                    tradeObject.TradeType = (TradeType)Enum.Parse(typeof(TradeType), reader["TradeType"].ToString());
                    tradeObject.PersonName = reader["PersonName"].ToString();
                    tradeObject.PersonID = reader["PersonID"].ToString();
                    tradeObject.PersonPhoneNumber = reader["PersonPhoneNumber"].ToString();
                    tradeObject.Brand = reader["Brand"].ToString();
                    tradeObject.Model = reader["Model"].ToString();
                    tradeObject.PhoneColor = reader["PhoneColor"].ToString();
                    tradeObject.Price = Convert.ToDecimal(reader["Price"]);
                    tradeObject.IMEI = reader["IMEI"].ToString();
                    tradeObject.OperName = reader["OperName"].ToString();
                    tradeObject.OperDate = Convert.ToDateTime(reader["OperDate"]);
                    tradeObject.SendToServer = Convert.ToBoolean(reader["SendToServer"]);
                    tradeObjectList.Add(tradeObject);
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("获取未提交记录出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return tradeObjectList;
        }

        public int InsertTradeObject(TradeObject tradeObject)
        {
            try
            {
                string sql = global::MobilePhoneLibrary.Properties.Resources.SQL_Insert_Trade;
                OleDbParameter parameter0 = new OleDbParameter("@TradeID", tradeObject.TradeID);
                OleDbParameter parameter1 = new OleDbParameter("@TradeType",tradeObject.TradeType.ToString());
                OleDbParameter parameter2 = new OleDbParameter("@PersonName", tradeObject.PersonName);
                OleDbParameter parameter3 = new OleDbParameter("@PersonID", tradeObject.PersonID);
                OleDbParameter parameter4 = new OleDbParameter("@PersonPhoneNumber", tradeObject.PersonPhoneNumber);
                OleDbParameter parameter5 = new OleDbParameter("@Brand", tradeObject.Brand);
                OleDbParameter parameter6 = new OleDbParameter("@Model", tradeObject.Model);
                OleDbParameter parameter7 = new OleDbParameter("@PhoneColor", tradeObject.PhoneColor);
                OleDbParameter parameter8 = new OleDbParameter("@Price", tradeObject.Price);
                OleDbParameter parameter9 = new OleDbParameter("@IMEI", tradeObject.IMEI);
                OleDbParameter parameter10 = new OleDbParameter("@OperName", tradeObject.OperName);
                OleDbParameter parameter11 = new OleDbParameter("@OperDate", tradeObject.OperDate.ToString());
                OleDbParameter parameter12 = new OleDbParameter("@SendToServer", tradeObject.SendToServer);
                return ExecuteNonQuery(connectionOfDataBase, sql, parameter0, parameter1, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7, parameter8, parameter9, parameter10, parameter11, parameter12);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("将记录插入数据库出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public int UpdateTradeByTradeID(TradeObject tradeObject, string tradeID)
        {
            try
            {
                string sql = global::MobilePhoneLibrary.Properties.Resources.SQL_Update_Trade_By_TradeID;
                OleDbParameter parameter0 = new OleDbParameter("@TradeID", tradeObject.TradeID);
                OleDbParameter parameter1 = new OleDbParameter("@TradeType", tradeObject.TradeType.ToString());
                OleDbParameter parameter2 = new OleDbParameter("@PersonName", tradeObject.PersonName);
                OleDbParameter parameter3 = new OleDbParameter("@PersonID", tradeObject.PersonID);
                OleDbParameter parameter4 = new OleDbParameter("@PersonPhoneNumber", tradeObject.PersonPhoneNumber);
                OleDbParameter parameter5 = new OleDbParameter("@Brand", tradeObject.Brand);
                OleDbParameter parameter6 = new OleDbParameter("@Model", tradeObject.Model);
                OleDbParameter parameter7 = new OleDbParameter("@PhoneColor", tradeObject.PhoneColor);
                OleDbParameter parameter8 = new OleDbParameter("@Price", tradeObject.Price);
                OleDbParameter parameter9 = new OleDbParameter("@IMEI", tradeObject.IMEI);
                OleDbParameter parameter10 = new OleDbParameter("@OperName", tradeObject.OperName);
                OleDbParameter parameter11 = new OleDbParameter("@OperDate", tradeObject.OperDate.ToString());
                OleDbParameter parameter12 = new OleDbParameter("@SendToServer", tradeObject.SendToServer);
                OleDbParameter parameter13 = new OleDbParameter("@TradeID", tradeID);
                return ExecuteNonQuery(connectionOfDataBase, sql, parameter0, parameter1, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7, parameter8, parameter9, parameter10, parameter11, parameter12, parameter13);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("更新记录出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }
    }
}

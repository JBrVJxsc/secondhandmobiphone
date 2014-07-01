
using System;
namespace MobilePhoneLibrary.Classes.Objects
{
    public class BrandObject : IComparable
    {
        public string EnglishName
        {
            get;
            set;
        }

        public string ChineseName
        {
            get;
            set;
        }

        public int SortID
        {
            get;
            set;
        }

        public override string ToString()
        {
            return ChineseName + " " + EnglishName;
        }

        #region IComparable 成员

        int IComparable.CompareTo(object obj)
        {
            BrandObject brandObject = obj as BrandObject;
            if (SortID > brandObject.SortID)
                return 1;
            if (SortID < brandObject.SortID)
                return -1;
            return 0;
        }

        #endregion
    }
}

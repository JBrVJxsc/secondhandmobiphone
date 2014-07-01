
using System;
namespace MobilePhoneLibrary.Classes.Objects
{
    public class ModelObject : IComparable
    {
        public string BrandEnglishName
        {
            get;
            set;
        }

        public string ModelName
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
            return ModelName;
        }

        #region IComparable 成员

        int IComparable.CompareTo(object obj)
        {
            ModelObject modelObject = obj as ModelObject;
            if (SortID > modelObject.SortID)
                return 1;
            if (SortID < modelObject.SortID)
                return -1;
            return 0;
        }

        #endregion

    }
}

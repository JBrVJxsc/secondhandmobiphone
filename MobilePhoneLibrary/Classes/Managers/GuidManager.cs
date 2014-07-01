using System;

namespace MobilePhoneLibrary.Classes.Managers
{
    public class GuidManager
    {
        public static string GetNewGuid()
        {
            return Guid.NewGuid().ToString("B");
        }
    }
}

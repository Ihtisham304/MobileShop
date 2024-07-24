using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfaqMobileShop.Shared
{
    public static class Helper
    {
        public static string  ConvertToBase64(byte[] byteArray)
        {
            if (byteArray == null)
            {
                return string.Empty;
            }
            return $"data:image/jpeg;base64,{Convert.ToBase64String(byteArray)}";
        }
    }
}

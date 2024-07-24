using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfaqMobileShop.Shared.DTO
{
    public class BuyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public DateTime Date { get; set; }
        public string MobileNumber { get; set; }
        public string CNIC { get; set; }
        public string Adrss { get; set; }
        public string IMEI1 { get; set; }
        public string IMEI2 { get; set; }
        public byte[] CNICPicture { get; set; } = new byte[byte.MaxValue];
        public string Specs { get; set; }
        public string Color { get; set; }
        public int PurchasePrice { get; set; }
        public string MobileModel { get; set; }
    }
}

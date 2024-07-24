using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfaqMobileShop.Shared.Models
{
    public class Buy: BaseEntity
    {
        public string Name { get; set; }
        public string FName { get; set; }
        public DateTime Date { get; set; }
        public string MobileNumber { get; set; }
        public string CNIC { get; set; }
        public string Adrss { get; set; }
        public string IMEI1 { get; set; }
        public string IMEI2 { get; set; }
        public byte[] CNICPicture { get; set; }
        public string Specs { get; set; }
        public string Color { get; set; }
        public int PurchasePrice { get; set; }
        public string MobileModel { get; set; }
     

}
}

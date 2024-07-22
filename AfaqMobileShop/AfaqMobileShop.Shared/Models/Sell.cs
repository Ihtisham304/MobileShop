using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfaqMobileShop.Shared.Models
{
    public class Sell : BaseEntity
    {
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; }
        public string IMEI1 { get; set; }
        public string IMEI2 { get; set; }
        public DateTime SellDate { get; set; }
        public int  Price { get; set; }
        public string Warranty { get; set; }
        public string Garranty { get; set; }
        public int Wasol { get; set; }
        public int Baqaya { get; set; }
    }
}

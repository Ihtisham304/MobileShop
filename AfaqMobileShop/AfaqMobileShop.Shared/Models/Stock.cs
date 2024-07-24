using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfaqMobileShop.Shared.Models
{
    public class Stock:BaseEntity
    {
        public string MobileName { get; set; }
        public int  Quantity { get; set; }
    }
}

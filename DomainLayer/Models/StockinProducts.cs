using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class StockinProducts
    {
        public int RefNo { get; set; }
        public string Stockinby { get; set; }
        public string Vendor { get; set; }
        public int Contact_Number { get; set; }
        public string Stockdate { get; set; }
        public int Entry_Quantity { get; set; }
        public object AppUser { get; set; }
    }
}

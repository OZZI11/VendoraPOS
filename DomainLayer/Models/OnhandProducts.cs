using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class OnhandProducts
    {
        public string PCODE { get; set; }
        public string BARCODE { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Reorder { get; set; }
        public string Stockonhand { get; set; }
        public string RefNo { get; set; }
        public string Stockinby { get; set; }
        public string Vendor { get; set; }
        public string Contact_Number { get; set; }
        public string Stockdate { get; set; }
        public string Entry_Quantityt { get; set; }
    }
}

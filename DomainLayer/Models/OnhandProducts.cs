using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class OnhandProducts
    {
        public int PCODE { get; set; }
        public string? BARCODE { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Reorder { get; set; }
        public int Stockonhand { get; set; }
   
    }
}


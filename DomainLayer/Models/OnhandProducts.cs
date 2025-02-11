﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class OnhandProducts
    {
        public int PCODE { get; set; }
        public int BARCODE { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public bool Price { get; set; }
        public int Reorder { get; set; }
        public int Stockonhand { get; set; }
        public int RefNo { get; set; }
        public string Stockinby { get; set; }
        public string Vendor { get; set; }
        public int Contact_Number { get; set; }
        public string Stockdate { get; set; }
        public int Entry_Quantity { get; set; }
    }
}


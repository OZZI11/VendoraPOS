﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class SoldProduct
    {
        [Key]

        public int PCODE { get; set; }
        public int BARCODE { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public bool Price { get; set; }
        public int Quantity { get; set; }
        public bool Discount { get; set; }
        public bool Total { get; set; }



    }
}

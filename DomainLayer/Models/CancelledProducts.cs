﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class CancelledProducts
    {

        public int TransactionNo { get; set; }
        public int PCODE { get; set; }
        public string Name { get; set; }
        public bool Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool Total { get; set; }
        public string Date { get; set; }
        public string VoidBy { get; set; }
        public string CancelledBy { get; set; }
        public string Reason { get; set; }
        public string Action { get; set; }




    }
}

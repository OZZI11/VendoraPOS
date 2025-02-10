﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class CancelledProducts
    {

        public string TransactionNo { get; set; }
        public string PCODE { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Total { get; set; }
        public string Date { get; set; }
        public string VoidBy { get; set; }
        public string CancelledBy { get; set; }
        public string Reason { get; set; }
        public string Action { get; set; }




    }
}

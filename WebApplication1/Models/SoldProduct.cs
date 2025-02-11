using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SoldProduct
    {
        [Key]

        public string PCODE { get; set; }
        public string BARCODE { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }           
        public string Price {  get; set; }
        public string Quantity {  get; set; }
        public string Discount { get; set; }
        public string Total { get; set; }



    }
}

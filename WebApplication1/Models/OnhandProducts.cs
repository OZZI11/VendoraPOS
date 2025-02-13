using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Areas.Identity.Data;

namespace WebApplication1.Models
{
    public class OnhandProducts
    {
        [Key]
       public string? PCODE { get; set; }


        public int BARCODE { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Reorder { get; set; }
        public string Stockonhand { get; set; }
       


     
    }
}


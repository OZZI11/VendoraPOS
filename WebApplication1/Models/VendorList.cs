using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class VendorList
    {
        [Key]
        public string Vendor {  get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string MobileNo {  get; set; }
        public string Schedule { get; set; }

    }
}

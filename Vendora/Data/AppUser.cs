using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendora.Data
{
    public class AppUser : IdentityUser
    {
        public virtual DomainLayer.Models.OnhandProducts OnhandProducts { get; set; }
    }
}

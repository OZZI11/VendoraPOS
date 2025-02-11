using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    [Required]
    public string? Name { get; set; }
    [ForeignKey(nameof(PCODE))]
    public int? PCODE { get; set; }
    public virtual Models.OnhandProducts OnhandProducts { get; set; }
}


using Microsoft.AspNetCore.Identity;
using ApplicationDbContextOnly.Models;
using System.Collections.Generic;

namespace ApplicationDbContextOnly.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Employee Employees { get; set; }
        public virtual PhotoCopyCenter PhotoCopyCenter { get; set; }
    }
}
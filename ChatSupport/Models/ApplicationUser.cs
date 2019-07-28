using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ChatSupport.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool isBusy { get; set; }
        public string DisplayName { get; set; }
    }
}

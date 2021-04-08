using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Identity.Models.Domain
{
    public class User :IdentityUser
    {
        public string Gender { get; set; }
        public string Region { get; set; }
    }
}

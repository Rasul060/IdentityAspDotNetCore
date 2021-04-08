using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Identity.Models.Domain
{
    public class Role :IdentityRole
    {
        public DateTime? DateTimeAdded { get; set; }=DateTime.Now;
    }
}

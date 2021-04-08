using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Identity.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace Identity.CustomValidations
{
    public class CustomPassword : IPasswordValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            List<IdentityError> errors = new List<IdentityError>();

            if (password.Length < 6)
                errors.Add(new IdentityError { Code = "PasswordLength", Description = "Zehmet olmasa azi 6 karakder girin." });

            if (password.ToLower().Contains(user.UserName.ToLower()))
                errors.Add(new IdentityError { Code = "PasswordContainsUserName", Description = "Lütfen şifre içerisinde isdifadci adını yazmayın." });

            return Task.FromResult(!errors.Any() ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.ViewModel.UserViewModel
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Isdifadeçi adını boş qoymayın...")]
        [StringLength(15, ErrorMessage = "En azı 3 hərf daxil edin..", MinimumLength = 3)]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email boş qoymayın...")]
        [EmailAddress(ErrorMessage = "Email formatinı düz girin...")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrəni boş qoymayın...")]
        [DataType(DataType.Password, ErrorMessage = "ammatin gözunə soxma...")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}

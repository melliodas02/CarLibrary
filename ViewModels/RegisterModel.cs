using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarLib.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Почта не указана")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен не верно")]
        public string ConfirmPassword { get; set; }
    }
}

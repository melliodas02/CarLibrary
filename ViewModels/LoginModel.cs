using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarLib.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указан логин")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль не указан")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

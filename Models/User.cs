using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CarLib.Models
{
    public class User
    {
        public int ID { get; set; }
        [DisplayName("Логин")]
        public string Email { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}

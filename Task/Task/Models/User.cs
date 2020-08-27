using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Models
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(255, ErrorMessage = "Имя должен состоять не больше чем из 255 символов")]
        [Required(ErrorMessage = "Укажите имя пользователя.")]
        public string Name { get; set; }
        [StringLength(255, ErrorMessage = "Логин должен состоять не больше чем из 255 символов")]
        [Required(ErrorMessage = "Укажите логин пользователя.")]
        public string Login { get; set; }
        [StringLength(255, ErrorMessage = "Пароль должен состоять не больше чем из 255 символов")]
        [Required(ErrorMessage = "Введите пароль.")]
        public string Password { get; set; }
    }
}

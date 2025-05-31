using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.Entities
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле 'Имя' обязательно для заполнения.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле 'Фамилия' обязательно для заполнения.")]
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        [Required(ErrorMessage = "Поле 'Дата' обязательно для заполнения.")]
        public DateTime Age { get; set; }
        [Required(ErrorMessage = "Поле 'Пол' обязательно для заполнения.")]
        public bool Gender  { get; set; }
        [Required(ErrorMessage = "Поле 'Почта' обязательно для заполнения.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Поле 'Номер телефона' обязательно для заполнения.")]
        public int NumberPhone {  get; set; }
        [Required(ErrorMessage = "Поле 'Пароль' обязательно для заполнения.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string PasswordHash { get; set; } // Для хранения хеша пароля
        public string Salt { get; set; } // Для хранения соли пароля
        public string ProfilePicture { get; set; }
        [Required]
        public int UserLevel { get; set; }
        [Required]
        public DateTime DareCreated { get; set; }
        public Skills Skills { get; set; }
        [Required]
        public bool IsDel {  get; set; }
        [Required]
        public Role Role { get; set; }
        public Location Location { get; set; }


    }   
}

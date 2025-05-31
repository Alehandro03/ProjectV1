using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.Entities
{
    public class Skills
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле 'Имя' обязательно для заполнения.")]
        public string Name { get; set; }
    }
}

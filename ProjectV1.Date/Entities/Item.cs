using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.Entities
{
    public class Item
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Discription { get; set; }
        [Required(ErrorMessage = "Поле 'Дата создания' обязательно для заполнения.")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Поле 'Тип предмета' обязательно для заполнения.")]
        public string TypeItem { get; set; }
    }
}

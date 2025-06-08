using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.Entities
{
    [Table("Item")]
    public class Item
    {
        [Required]
        public int Id { get; set; }
        public string Discription { get; set; }
        [Required(ErrorMessage = "Поле 'Дата создания' обязательно для заполнения.")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Поле 'Тип предмета' обязательно для заполнения.")]
        public string TypeItem { get; set; }
    }
}

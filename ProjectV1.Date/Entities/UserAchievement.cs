using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.Entities
{
    [Table("UserAchievement")]
    public class UserAchievement
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public ICollection<Achievement> Achievements { get; set; }
        [Required]
        public DateTime Date_Achievements { get; set; }

    }
}

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
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public List<Achievement> Achievements { get; set; }
        [Required]
        public DateTime Date_Achievements { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.Entities
{
    public class UserAchievements
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public List<Achievements> Achievements { get; set; }
        [Required]
        public DateTime Date_Achievements { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.Entities
{
    [Table("Achievement")]
    public  class Achievement
    {//1;25
        [Required]
        public int Id {  get; set; }
        [Required]
        public string Name  { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public virtual UserAchievement UserAchievements { get; set; }


    }
}

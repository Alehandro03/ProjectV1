using ProjectV1.Date.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.Entities
{
    [Table("Location")]
    public class Location
    {
        [Required]
        public int Id { get; set; }
        public virtual City City { get; set; }
        public int NumberHome {  get; set; }
        public int Floor { get; set; }
        public int RoomNumber { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}

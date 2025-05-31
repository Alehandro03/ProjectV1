using ProjectV1.Date.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.Entities
{
    public class Location
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public City City { get; set; }
        public int NumberHome {  get; set; }
        public int Floor { get; set; }
        public int RoomNumber { get; set; }

    }
}

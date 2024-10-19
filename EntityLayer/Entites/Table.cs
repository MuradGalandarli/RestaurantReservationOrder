using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public  class Table
    {
        [Key]
        public int TableId { get; set; }
        public string? FoodPortion { get; set; }
        public int? ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
        public int? MenuId { get; set; }
        public Menu? Menu { get; set; }
    }
}

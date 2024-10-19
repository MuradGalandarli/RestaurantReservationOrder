using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        public string? RestaurantName { get; set; }
        public string? RestaurantLocation { get; set; }
        public string? RestaurantDescription { get; set; }
        public bool Status { get; set; }    
        public int? RestaurantOwnerId { get; set; }
        public RestaurantOwner? RestaurantOwner { get; set; }
        public List<Menu>? Menu { get; set; }
        public List<Reservation>? Reservation { get; set; }
        public List<Comment>? Comment { get; set; }
        public List<Order>? Order { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }

    }
}

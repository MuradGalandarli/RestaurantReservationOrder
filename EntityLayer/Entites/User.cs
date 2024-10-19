using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? SureName { get; set; }
        public string? Locarion { get; set; }
        public string? PhoneNumber { get; set; }
        public List<Comment>? Comments { get; set; }   
        public List<Order>? Order { get; set; }   
        public List<Reservation>? Reservation { get; set; }
        public List<Restaurant>? Restaurants { get; set; }
        
    }
}

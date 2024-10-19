using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public class RestaurantOwner
    {
        [Key]
        public int RestaurantOwnerId { get; set; } 
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }     
        public List<Restaurant>? Restaurants { get; set; }
    }
}

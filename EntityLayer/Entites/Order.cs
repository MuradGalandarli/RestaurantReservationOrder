using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.Enums.Enum;

namespace EntityLayer.Entites
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime SaleDate { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public int? RestaurantId { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public Restaurant? Restaurant { get; set; }
        public int? MenuId { get; set; }
        public Menu? Menu { get; set; }
        
    }
}

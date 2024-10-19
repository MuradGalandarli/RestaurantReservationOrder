using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string? MenuName { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public decimal? Price { get; set; }
        public int? RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
        public List<Table>? Table { get; set; }
        public List<Order>? Orders { get; set; }



    }
}

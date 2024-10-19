using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public class Comment
    {
        
        public int CommentId { get; set; }
        public string? Review { get; set; }
        public int? RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }



    }
}

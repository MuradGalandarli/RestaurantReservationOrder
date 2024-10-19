using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public class Reservation
    {
        [Key]
        public int ResevationId { get; set; }
        public int TableNumber { get; set; }
        public int? RestaurandId { get; set; }   
        public Restaurant? Restaurant { get; set; }
        public List<Table>? Table { get; set; }
        public  int UserId { get; set; }
        public  User? User { get; set; }


    }
}

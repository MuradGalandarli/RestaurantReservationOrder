using EntityLayer.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ApplicationContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
        {

        }

        public DbSet<Restaurant> Restorants { get; set; }
        public DbSet<Menu>Menus { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Reservation>Reservations { get; set; } 
        public DbSet<RestaurantOwner> RestaurantOwners { get; set; }
        public DbSet<Table>Tables { get; set; }
        public DbSet<User> Users { get; set; }
       
    }
}

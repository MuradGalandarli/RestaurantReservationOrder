using DataAccessLayer.Abstriction;
using EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concret
{
    public class RepositoryUser:Generic<User>,IEFUser
    {
        private readonly ApplicationContext _context;
        public RepositoryUser(ApplicationContext context):base(context) 
        {
            _context = context;
        }


    }
}

using DataAccessLayer.Abstriction;
using EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concret
{
    public class RepositoryRestornat:Generic<Restaurant>,IEFRetorant
    {
        private readonly ApplicationContext _context;
        public RepositoryRestornat(ApplicationContext context):base(context)
        {
            _context = context; 
        }


    }
}

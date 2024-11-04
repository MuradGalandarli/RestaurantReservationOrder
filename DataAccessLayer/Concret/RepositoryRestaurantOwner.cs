using DataAccessLayer.Abstriction;
using EntityLayer.Entites;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concret
{
    public class RepositoryRestaurantOwner:Generic<RestaurantOwner>,IEFRestaurantOwner
    {
        private readonly ApplicationContext _Context;
        public RepositoryRestaurantOwner(ApplicationContext _Context):base(_Context)
        {
            this._Context = _Context;
        }


    }
}

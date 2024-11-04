using BusnessLayer.Abstraction;
using DataAccessLayer.Abstriction;
using EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnessLayer.Concret
{
    public class RestaurantOwnerManager : IServiceRestaurantOwner
    {
        private readonly IEFRestaurantOwner _eFRestaurantOwner;
        public RestaurantOwnerManager(IEFRestaurantOwner _eFRestaurantOwner)
        {
            this._eFRestaurantOwner = _eFRestaurantOwner;
        }

        public async Task<RestaurantOwner> Add(RestaurantOwner t)
        {
            var data = await _eFRestaurantOwner.Add(t);
            return data;
        }

        public async Task<RestaurantOwner> Delete(int id)
        {
            var data = await _eFRestaurantOwner.Delete(id);
            return data;
        }

        public async Task<List<RestaurantOwner>> GetAll()
        {
            var data = await _eFRestaurantOwner.GetAll();
            return data;
        }

        public async Task<RestaurantOwner> GetById(int id)
        {
            var data = await _eFRestaurantOwner.GetId(id);
            return data;
        }

        public async Task<RestaurantOwner> Update(RestaurantOwner t)
        {
            var data = await _eFRestaurantOwner.Update(t);
            return data;
        }
    }
}

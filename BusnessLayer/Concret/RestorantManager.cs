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
    public class RestorantManager : IServiceRestorant
    {
        private readonly IEFRetorant _eFRetorant;
        public RestorantManager(IEFRetorant eFRetorant) 
        {
          _eFRetorant = eFRetorant;
        }

        public async Task<Restaurant> Addd(Restaurant t)
        {
           var result = await _eFRetorant.Add(t);
            return result;
        }

        public async Task<Restaurant> Delete(int id)
        {
            var result = await _eFRetorant.Delete(id);
            return result;
        }

        public async Task<List<Restaurant>> GetAll()
        {
            var result = await _eFRetorant.GetAll();
            return result;  
        }

        public async Task<Restaurant> GetId(int id)
        {
          var result = await _eFRetorant.GetId(id);
            return result;
        }

        public async Task<Restaurant> Update(Restaurant t)
        {
            var result = await _eFRetorant.Update(t); 
            return result;
        }
    }
}

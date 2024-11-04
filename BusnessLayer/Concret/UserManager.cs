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
    public class UserManager : IServiceUser
    {
        private readonly IEFUser _user;
        public UserManager(IEFUser _user)
        {
            this._user = _user;
        }

        public async Task<User> Add(User t)
        {
            var result = await _user.Add(t);
            return result;
        }

        public async Task<User> Delete(int id)
        {
           var result = await _user.Delete(id);
            return result;  
        }

        public async Task<List<User>> GetAll()
        {
           var result = await _user.GetAll();
            return result;
        }

        public async Task<User> GetById(int id)
        {
            var result = await _user.GetId(id);
            return result;
        }

        public async Task<User> Update(User t)
        {
           var result =await _user.Update(t);
            return result;  
        }
    }
}

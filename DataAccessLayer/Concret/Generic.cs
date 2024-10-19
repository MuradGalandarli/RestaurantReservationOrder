using DataAccessLayer.Abstriction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concret
{
    public class Generic<T> : IGeneric<T> where T :class
    {
        private readonly ApplicationContext _context;
        public Generic(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<T> Add(T t)
        {
            await _context.Set<T>().AddAsync(t);
            await _context.SaveChangesAsync();
            return t;
        }

        public async Task<T> Delete(int id)
        {
            var result = await GetId(id);
            _context.Set<T>().Remove(result);
            await _context.SaveChangesAsync();
            
            return result;
        }

        public async Task<List<T>> GetAll()
        {
          var result = await _context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> GetId(int id)
        {
           var result = await _context.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<T> Update(T t)
        {
            _context.Set<T>().Update(t);
            return t;
        }

    }
}

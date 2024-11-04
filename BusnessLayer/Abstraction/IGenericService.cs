using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnessLayer.Abstraction
{
    public interface IGenericService<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(T t);
        Task<T> Update(T t);
        Task<T> Delete(int id);
    }
}

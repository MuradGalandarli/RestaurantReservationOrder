using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnessLayer.Abstraction
{
    public  interface IGenericService<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetId(int id);
        Task<T> Addd(T t);
        Task<T> Update(T t);
        Task<T> Delete(int id);
    }
}

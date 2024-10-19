using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstriction
{
     public interface IGeneric<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetId(int id);
        Task<T> Add(T t);
        Task<T> Update(T t);
        Task<T> Delete(int id);
    }
}

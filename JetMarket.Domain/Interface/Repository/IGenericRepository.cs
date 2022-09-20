using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetMarket.Domain.Interface.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get (Guid id);
        Task<IEnumerable<T>> GetAll ();
        Task<T> Insert(T entity);
        Task<bool> Delete(Guid id);
        Task<T> Update(T entity);
    }
}

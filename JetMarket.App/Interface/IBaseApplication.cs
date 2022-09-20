using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetMarket.App.Interface
{
    public interface IBaseApplication<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> Get(Guid id);
        Task<bool> Delete(Guid id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
    }
}

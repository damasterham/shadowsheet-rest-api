using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Repositories
{
    public interface IRepository<T>
    {
        void Create(T entity);

        //T Get(object id);
        IEnumerable<T> GetAll();

        void Update(T entity);

        void Delete(T entity);
    }
}

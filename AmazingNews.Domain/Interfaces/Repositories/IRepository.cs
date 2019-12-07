using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingNews.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T:class
    {
        bool Create(T entity);
        T Read(Guid id);
        IEnumerable<T> ReadAll();
        bool Update(T entity);
        bool Delete(Guid id);
    }
}

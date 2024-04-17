using System;
using System.Linq.Expressions;
using MAUIUI.Core.Entities;

namespace MAUIUI.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        public void Add(T entity);
        public void Delete(T entity);
        public void Update(T entity);
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);
        public T Get(Expression<Func<T, bool>> filter);
        public void importRecords(string dataFile, string tableName);
    }
}


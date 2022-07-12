using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository : IDisposable
    {
        TEntity Create<TEntity>(TEntity createEntity) where TEntity : class;   //Para crear un registro
        bool Update<TEntity>(TEntity updateEntity) where TEntity : class;   //Para actualizar un registro
        bool Delete<TEntity>(TEntity deleteEntity) where TEntity : class;   //Para eliminar un registro
        TEntity FindEntity<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class;    //Para buscar un registro
        IEnumerable<TEntity> FindEntitySet<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class;    //Para buscar varios registros
        IPagedList<TEntity> FindEntitySetPage<TEntity>(Expression<Func<TEntity, bool>> criteria, Expression<Func<TEntity, string>> order, int page, int pageSize) where TEntity : class;    //Para buscar varios registros
    }
}

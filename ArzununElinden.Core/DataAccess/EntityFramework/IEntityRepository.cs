using ArzununElinden.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArzununElinden.Core.DataAccess.EntityFramework
{
    public interface IEntityRepository<TEntity> where TEntity:IEntity
    {
        void Add(TEntity entity); 
        void Update(TEntity entity);
        void Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity,bool>> filter=null);
        ICollection<TEntity> GetAll(Expression<Func<TEntity,bool>> filter=null);

    }
}

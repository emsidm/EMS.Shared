using System;
using System.Linq;

namespace EMS.DataAccess.Abstractions
{
    public interface IDataSource : IDisposable
    {
        IQueryable<TEntity> Entities<TEntity>() where TEntity : class;
        
        string Name { get; set; }
    }
}
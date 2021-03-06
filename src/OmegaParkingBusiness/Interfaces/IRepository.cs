using OmegaParkingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OmegaParkingBusiness.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<List<TEntity>> ObterTodos();

        Task<TEntity> ObterPorId(Guid id);

        Task Adicionar(TEntity entity);

        Task<int> SaveChanges();

        //Task Atualizar(TEntity entity);

        //Task Remover(Guid id);

        //Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);        
    }
}

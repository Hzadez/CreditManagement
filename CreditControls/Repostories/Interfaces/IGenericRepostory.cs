using CreditControls.Models;

namespace CreditControls.Repostories.Interfaces
{
    public interface IGenericRepostory<TEntity> where TEntity : BaseEntitie
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsyn(int id);
    }
}
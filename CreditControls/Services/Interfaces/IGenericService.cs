using CreditControls.Models;

namespace CreditControls.Services.Interfaces
{
    public interface IGenericService<TModel,TEntity> where TEntity : BaseEntitie where TModel :class
    {
        Task<TModel> CreateAsync(TModel model);
        Task<TModel> UpdateAsync(TModel model);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsyn(int id);
    }
}

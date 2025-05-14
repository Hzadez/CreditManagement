using AutoMapper;
using CreditControls.Models;
using CreditControls.Repostories.Interfaces;
using CreditControls.Services.Interfaces;

namespace CreditControls.Services.Implamentation
{
    public class GenericService<TModel, TEntity> : IGenericService<TModel, TEntity> where TEntity : BaseEntitie where TModel : class
    {
        private readonly IGenericRepostory<TEntity> _genericRepostory;
        private readonly IMapper _mapper;
        public GenericService(IMapper _mapper ,IGenericRepostory<TEntity> genericRepostory)
        {
            _genericRepostory = genericRepostory;
            _mapper = _mapper;
        }
    
        public async Task<bool> DeleteAsync(int id) => await _genericRepostory.DeleteAsync(id);
       
        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var entities = await _genericRepostory.GetAllAsync();
            var models =  _mapper.Map<IEnumerable<TModel>>(entities);
            return models;
        }
        public async Task<TModel> GetByIdAsyn(int id)
        {
            var entity = await _genericRepostory.GetByIdAsyn(id);
            return _mapper.Map<TModel>(entity);
        }
        public async Task<TModel> UpdateAsync(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            var updatedEntity = await _genericRepostory.Update(entity);
            var updatedModel = _mapper.Map<TModel>(updatedEntity);
            return updatedModel;
        }
        public async Task<TModel> CreateAsync(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            var createdEntity = await _genericRepostory.CreateAsync(entity);
            var createdModel = _mapper.Map<TModel>(createdEntity);
            return createdModel;
        }
    }
    
}

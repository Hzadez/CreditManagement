using CreditControls.Data;
using CreditControls.Models;
using CreditControls.Repostories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CreditControls.Repostories.Implamentation
{
    public class GenericRepostory<TEntity> : IGenericRepostory<TEntity> where TEntity : BaseEntitie
    {
        private readonly CreditControlsDb _dbContext;
        private readonly DbSet<TEntity> _dbset;

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
            _dbContext.SaveChanges();
            return (entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _dbset.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            entity.IsDeleted = true;
            _dbset.Update(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            var entities = await _dbset.Where(e => !e.IsDeleted).AsNoTracking<TEntity>().ToListAsync();
            return entities;
        }

        public async Task<TEntity> GetByIdAsyn(int id)
        {
            await _dbset.FindAsync();
            var entity = await _dbset.AsNoTracking<TEntity>().FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted);
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            entity.UpdatedAt = DateTime.Now;
            _dbset.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

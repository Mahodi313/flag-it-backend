using flag_it_backend.Data;
using flag_it_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace flag_it_backend.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> DeleteAsync(int id)
        {
            var entityToDelete = await GetByIdAsync(id);

            if (entityToDelete == null)
            {
                throw new InvalidOperationException("Entity not found");
            }

            _dbSet.Remove(entityToDelete);
            await _context.SaveChangesAsync();

            return entityToDelete;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity == null)
            {
                throw new InvalidOperationException("Entity not found");
            }

            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}

namespace flag_it_backend.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task<T> CreateAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task<T> DeleteAsync(int id);
    }
}

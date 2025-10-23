namespace CatchUpPlatform.API.shared.domain.Repositories;

public interface IBaseRepository<TEntity>
{
    Task AddAsync(TEntity entity);
    Task<TEntity> FindByIdAsync(int id);
    Task<IEnumerable<TEntity>> ListAsync();
    void Update(TEntity entity);
    void Remove(TEntity entity);
}
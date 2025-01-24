using ProEventos.Domain;
using ProEventos.Persistence.Data;
using ProEventos.Persistence.Repositories.Interfaces;

namespace ProEventos.Persistence.Repositories.Classes;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
{
    private readonly DataContext _dataContext;
    public Repository(DataContext dataContext){
        _dataContext = dataContext;
    }

    public async Task<TEntity> Add(TEntity entity)
    {
        var result = await _dataContext.Set<TEntity>().AddAsync(entity);
        await _dataContext.SaveChangesAsync();
        return result.Entity;

    }

    public Task<TEntity> GetEntity(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
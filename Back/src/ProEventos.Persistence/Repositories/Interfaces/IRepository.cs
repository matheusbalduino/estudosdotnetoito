namespace ProEventos.Persistence.Repositories.Interfaces;

public interface IRepository<IEntity>
{
    Task<IEntity> Add(IEntity entity);
    Task<IEntity> Update(IEntity entity);
    Task<IEntity> GetEntity(Guid Id);
}
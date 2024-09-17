using Microsoft.EntityFrameworkCore;
using SoftSesApi.Data;


namespace SoftSesApi.Abstracts;

public abstract class BaseRepository<TEntity> where TEntity : class
{
    private readonly DbSet<TEntity> _dbSet;
    
    public BaseRepository(AppDbContext context)
    {
        _dbSet = context.Set<TEntity>();
    }

    public DbSet<TEntity> GetContext()
    {
        return _dbSet;
    }
}
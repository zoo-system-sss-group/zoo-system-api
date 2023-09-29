using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class BaseDAO<TEntity> where TEntity : BaseEntity
{
    public static async Task<List<TEntity>> GetAllAsync()
    {
        var list = new List<TEntity>();
        using (var context = new AppDBContext())
        {
            list = await context.Set<TEntity>().ToListAsync();
        }
        return list;
    }

    public static async Task<TEntity?> GetByIdAsync(int id)
    {
        TEntity? entity;
        using (var context = new AppDBContext())
        {
            entity = await context.Set<TEntity>().FindAsync(id);
        }
        return entity;
    }

    public static async Task SaveAsync(TEntity p)
    {
        using (var context = new AppDBContext())
        {
            p.CreationDate = DateTime.Now;
            context.Set<TEntity>().Add(p);
            await context.SaveChangesAsync();
        }
    }

    public static async Task SaveRangeAsync(List<TEntity> ls)
    {
        using (var context = new AppDBContext())
        {
            DateTime now = DateTime.Now;
            ls.ForEach(x =>
            {
                x.CreationDate = now;
            });
            await context.Set<TEntity>().AddRangeAsync(ls);
            await context.SaveChangesAsync();
        }
    }

    public static async Task UpdateAsync(TEntity p)
    {
        using (var context = new AppDBContext())
        {
            p.ModificationDate = DateTime.Now;
            context.Entry(p).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }

    public static async Task DeleteAsync(TEntity p)
    {
        using (var context = new AppDBContext())
        {
            context.Set<TEntity>().Remove(p);
            await context.SaveChangesAsync();
        }
    }

    public static async Task SoftDeleteAsync(TEntity p)
    {
        using (var context = new AppDBContext())
        {
            p.IsDeleted = true;
            p.DeletionDate = DateTime.Now;
            context.Entry(p).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}

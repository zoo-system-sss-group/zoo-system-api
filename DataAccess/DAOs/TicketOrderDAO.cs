using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class TicketOrderDAO
{
    public static async Task<List<TicketOrder>> GetAllTicketOrdersAsync()
    {
        var list = new List<TicketOrder>();
        using (var context = new AppDBContext())
        {
            list = await context.TicketOrders.Include(x => x.Tickets).ToListAsync();
        }
        return list;
    }

    public static async Task<TicketOrder?> GetTicketOrderByIdAsync(int id)
    {
        TicketOrder? entity;
        using (var context = new AppDBContext())
        {
            entity = await context.TicketOrders.Include(x => x.Tickets)
                                    .FirstOrDefaultAsync(x => x.Id == id);
        }
        return entity;
    }

    public static async Task SaveAsync(TicketOrder p)
    {
        using (var context = new AppDBContext())
        {
            p.CreationDate = DateTime.Now;
            context.TicketOrders.Add(p);
            await context.SaveChangesAsync();
        }
    }

    public static async Task UpdateAsync(TicketOrder p)
    {
        using (var context = new AppDBContext())
        {
            p.ModificationDate = DateTime.Now;
            context.Entry(p).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }

    public static async Task DeleteAsync(TicketOrder p)
    {
        using (var context = new AppDBContext())
        {
            context.TicketOrders.Remove(p);
            await context.SaveChangesAsync();
        }
    }

    public static async Task SoftDeleteAsync(TicketOrder p)
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

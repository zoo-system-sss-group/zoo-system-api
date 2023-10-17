using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class TicketOrderDAO : BaseDAO<TicketOrder>
{
    public static async Task<List<TicketOrder>> GetAllTicketOrdersAsync()
    {
        var list = new List<TicketOrder>();
        using (var context = new AppDBContext())
        {
            list = await context.TicketOrders
                    .Include(x => x.Tickets)
                    .ToListAsync();
        }
        return list;
    }

    public static async Task<TicketOrder?> GetTicketOrderByIdAsync(int id)
    {
        TicketOrder? entity;
        using (var context = new AppDBContext())
        {
            entity = await context.TicketOrders
                                    .Include(x => x.Tickets)
                                    .FirstOrDefaultAsync(x => x.Id == id);
        }
        return entity;
    }   
}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class TicketDAO : BaseDAO<Ticket>
{
    public static async Task<List<Ticket>> GetAllTicketDetailsAsync()
    {
        var tickets = new List<Ticket>();
        using (var context = new AppDBContext())
        {
            tickets = await context.Tickets
                            .Include(x => x.OrderInformation)
                            .ToListAsync();
        }
        return tickets;
    }
}

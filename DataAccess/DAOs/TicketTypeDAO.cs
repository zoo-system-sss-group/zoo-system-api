using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class TicketTypeDAO
{
    public static async Task<TicketType?> GetTicketTypeByCodeAsync(string code)
    {
        TicketType? type;
        using (var context = new AppDBContext())
        {
            type = await context.TicketTypes.FirstOrDefaultAsync(x => x.Code.Equals(code));
        }
        return type;
    }

    public static async Task<List<TicketType>> GetAllTicketTypesAsync()
    {
        var types = new List<TicketType>();
        using (var context = new AppDBContext())
        {
            types = await context.TicketTypes.ToListAsync();
        }
        return types;
    }
}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class CageHistoriesDAO
{
    public static async Task<List<CageHistory>> GetListAnimalByCageId(int id)
    {
        List<CageHistory>? cageHistoties;
        using (var context = new AppDBContext())
        {
            cageHistoties = await context.CageHistories.Where(ch => ch.CageId == id && ch.EndDate == null).ToListAsync();
        }
        return cageHistoties;
    }
}

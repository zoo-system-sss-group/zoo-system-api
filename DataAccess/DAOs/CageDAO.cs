using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class CageDAO : BaseDAO<Cage>
{
    public async Task<List<Cage>?> GetCageByAreaId(int id)
    {
        List<Cage>? cages;
        using (var context = new AppDBContext())
        {
            cages = await context.Cages.Where(c => c.AreaId == id).ToListAsync();
        }
        return cages;
    }
}

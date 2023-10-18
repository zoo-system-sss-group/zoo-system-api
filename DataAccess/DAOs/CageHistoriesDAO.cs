using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class CageHistoriesDAO : BaseDAO<CageHistory>
{
    private readonly AppConfiguration _configuration;
    public CageHistoriesDAO(AppConfiguration configuration) : base(configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<CageHistory>> GetListAnimalByCageId(int id)
    {
        List<CageHistory>? cageHistoties;
        using (var context = new AppDBContext(_configuration))
        {
            cageHistoties = await context.CageHistories.Where(ch => ch.CageId == id && ch.EndDate == null).ToListAsync();
        }
        return cageHistoties;
    }
}

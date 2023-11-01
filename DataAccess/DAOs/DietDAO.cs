using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DAOs;

public class DietDAO : BaseDAO<Diet>
{
    private readonly AppConfiguration _configuration;
    public DietDAO(AppConfiguration configuration) : base(configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<Diet>> GetAllDietsAsync()
    {
        var diets = new List<Diet>();
        using (var context = new AppDBContext(_configuration))
        {
            diets = await context.Diets
                            .Include(x => x.DietDetails)
                            .ThenInclude(d => d.Animal)
                            .ToListAsync();
        }
        return diets;
    }

    public async Task<Diet?> GetDietByIdAsync(int id)
    {
        Diet? diet;
        using (var context = new AppDBContext(_configuration))
        {
            diet = await context.Diets
                            .Include(x => x.DietDetails)
                            .ThenInclude(d => d.Animal)
                            .FirstOrDefaultAsync(x => x.Id == id);
        }
        return diet;
    }
}

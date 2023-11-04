using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class DietDetailDAO : BaseDAO<DietDetail>
{
    private readonly AppConfiguration _configuration;
    public DietDetailDAO(AppConfiguration configuration) : base(configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<DietDetail>> GetAllDietDetailsAsync()
    {
        var diets = new List<DietDetail>();
        using (var context = new AppDBContext(_configuration))
        {
            diets = await context.DietDetails
                            .Include(x => x.Animal)
                            .Include(x => x.Diet)
                            .ToListAsync();
        }
        return diets;
    }

    public async Task<DietDetail?> GetDietDetailByIdAsync(int id)
    {
        DietDetail? diet;
        using (var context = new AppDBContext(_configuration))
        {
            diet = await context.DietDetails
                            .Include(x => x.Animal)
                            .Include(x => x.Diet)
                            .FirstOrDefaultAsync(x => x.Id == id);
        }
        return diet;
    }
    public async Task<DietDetail?> GetDietDetailByAnimalIdAsync(int animalId)
    {
        DietDetail? dietDetail;
        using (var context = new AppDBContext(_configuration))
        {
            dietDetail = await context.DietDetails.Where(x => x.AnimalId == animalId && x.EndDate == null).FirstOrDefaultAsync();
        }
        return dietDetail;
    }
}

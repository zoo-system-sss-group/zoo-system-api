using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class DietDetailDAO
{
    public static async Task<DietDetail?> GetDietDetailByAnimalId(int id)
    {
        List<DietDetail>? dietDetails;
        using (var context = new AppDBContext())
        {
            dietDetails = await context.DietDetails.Where(ch => ch.AnimalId == id && ch.EndDate == null).ToListAsync();
        }
        return dietDetails[0];
    }

}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
    public class DietDetailDAO
    {
        public static async Task<List<DietDetail>?> GetDietDetailByAnimalId(int id)
        {
            List<DietDetail>? dietDetails;
            using (var context = new AppDBContext())
            {
                dietDetails = await context.DietDetails.Where(ch => ch.AnimalId == id && ch.EndDate == null).ToListAsync();
            }
            return dietDetails;
        }
    }
}

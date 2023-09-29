using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
    public class CageDAO : BaseDAO<Cage>
    {
        public static async Task<List<Cage>?> GetCageByAreaId(int id)
        {
            List<Cage>? cages;
            using (var context = new AppDBContext())
            {
                cages = await context.Cages.Where(c => c.AreaId == id).ToListAsync();
            }
            return cages;
        }
    }
}

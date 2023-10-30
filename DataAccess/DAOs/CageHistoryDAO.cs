using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
    public class CageHistoryDAO : BaseDAO<CageHistory>
    {
        private readonly AppConfiguration _configuration;
        public CageHistoryDAO(AppConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<CageHistory>?> GetCageHistoryByAnimalIdAsync(int animalId)
        {
            List<CageHistory>? cageHistories;
            using (var context = new AppDBContext(_configuration))
            {
                cageHistories = await context.CageHistories.Where(x => x.AnimalId == animalId).ToListAsync();
            }
            return cageHistories;
        }
    }
}

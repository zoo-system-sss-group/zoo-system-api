using DataAccess.DAOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.IRepositories;
namespace Application.Repositories
{
    public class CageHistoryRepository : ICageHistoryRepository
    {
        private readonly CageHistoryDAO cageHistoryDAO;

        public CageHistoryRepository(CageHistoryDAO cageHistoryDAO)
        {
            this.cageHistoryDAO = cageHistoryDAO;
        }
        public async Task AddCageHistoryAsync(CageHistory cageHistory)
        {
            var tmp = (await cageHistoryDAO.GetCageHistoryByAnimalIdAsync(cageHistory.AnimalId));
            if (tmp != null)
            {
                foreach (CageHistory history in tmp) 
                {
                    if (history.EndDate == null)
                    { 
                        history.EndDate = DateTime.Now;
                        await cageHistoryDAO.UpdateAsync(history);
                    }      
                }
            }
            await cageHistoryDAO.SaveAsync(cageHistory);
        }
    }
}

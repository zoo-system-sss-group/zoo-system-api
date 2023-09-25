using Application.IRepositories;
using Azure;
using DataAccess.DAOs;
using Domain.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class CageRepository : ICageRepository
    {
        public async Task<List<Cage>> GetCagesAsync()
            => await CageDAO.GetAllAsync();
        public async Task<Cage?> GetCageByIdAsync(int id)
        {
            var result = await CageDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            result.CageHistories = await CageHistoriesDAO.GetListAnimalByCageId(id);
            foreach(CageHistory ch in result.CageHistories)
            {
                ch.Animal = await AnimalDAO.GetByIdAsync(ch.AnimalId);
            }
            return result;
        }
        public async void AddCageAsync(Cage cage)
            => await CageDAO.SaveAsync(cage);
        public async void UpdateCageAsync(int id, Cage cage)
        {
            var result = await CageDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await CageDAO.UpdateAsync(cage);
        }
        public async void SoftDeleteCageAsync(int id)
        {
            var result = await CageDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await CageDAO.SoftDeleteAsync(result);
        }
    }
}

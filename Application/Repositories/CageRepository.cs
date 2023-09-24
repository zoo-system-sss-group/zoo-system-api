using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;
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
            => await CageDAO.GetByIdAsync(id);
        public async void AddCageAsync(Cage cage)
            => await CageDAO.SaveAsync(cage);
        public async void UpdateCageAsync(Cage cage)
        {
            var result = await CageDAO.GetByIdAsync(cage.Id);
            if (result == null)
                throw new Exception("Can not found!");
            await CageDAO.UpdateAsync(result);
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

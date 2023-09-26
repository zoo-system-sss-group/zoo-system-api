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
    public class DietRepository : IDietRepository
    {
        public async Task<List<Diet>> GetDietsAsync()
            => await DietDAO.GetAllAsync();
        public async Task<Diet?> GetDietByIdAsync(int id)
            => await DietDAO.GetByIdAsync(id);
        public async Task AddDietAsync(Diet diet)
            => await DietDAO.SaveAsync(diet);
        public async Task<Diet?> GetCurrentDietByAnimalIdAsync(int id)
        {
            var dietDetail = await DietDetailDAO.GetDietDetailByAnimalId(id);
            return await DietDAO.GetByIdAsync(dietDetail.DietId);
        } 
        
        public async Task UpdateDietAsync(int id, Diet diet)
        {
            var result = await DietDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await DietDAO.UpdateAsync(diet);
        }
        public async Task SoftDeleteDietAsync(int id)
        {
            var result = await DietDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await DietDAO.SoftDeleteAsync(result);
        }
    }
}

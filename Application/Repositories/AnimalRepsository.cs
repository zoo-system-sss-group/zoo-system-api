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
    public class AnimalRepsository : IAnimalRepository
    {
        public async Task<List<AnimalInformation>> GetAnimalsAsync()
            => await AnimalDAO.GetAllAsync();
        public async Task<AnimalInformation?> GetAnimalByIdAsync(int id)
            => await AnimalDAO.GetByIdAsync(id);
        public async Task<AnimalInformation?> GetAnimalDietByIdAsync(int id)
        {
            var result = await AnimalDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            result.DietDetails = await DietDetailDAO.GetDietDetailByAnimalId(id);
            return result;
        }
        public async Task AddAnimalsAsync(AnimalInformation animal)
            => await AnimalDAO.SaveAsync(animal);
        public async Task UpdateAnimalAsync(int id, AnimalInformation animal)
        {
            var result = await AnimalDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await AnimalDAO.UpdateAsync(animal);
        }
        public async Task SoftDeleteAnimalsAsync(int id)
        {
            var result = await AnimalDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await AnimalDAO.SoftDeleteAsync(result);
        }
    }
}

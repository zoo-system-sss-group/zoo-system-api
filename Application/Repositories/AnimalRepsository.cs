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
            result.DietDetails.FirstOrDefault().Diet = await DietDAO.GetByIdAsync(result.DietDetails.FirstOrDefault().DietId);
            return result;
        }
        public async void AddAnimalsAsync(AnimalInformation animal)
            => await AnimalDAO.SaveAsync(animal);
        public async void UpdateAnimalAsync(int id, AnimalInformation animal)
        {
            var result = await AnimalDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await AnimalDAO.UpdateAsync(animal);
        }
        public async void SoftDeleteAnimalsAsync(int id)
        {
            var result = await AnimalDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await AnimalDAO.SoftDeleteAsync(result);
        }
    }
}

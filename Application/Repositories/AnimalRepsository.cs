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
        public async Task<AnimalInformation?> GetAnimalsByIdAsync(int id)
            => await AnimalDAO.GetByIdAsync(id);
        public async void AddAnimalsAsync(AnimalInformation animal)
            => await AnimalDAO.SaveAsync(animal);
        public async void UpdateAnimalAsync(AnimalInformation animal)
        {
            var result = await AnimalDAO.GetByIdAsync(animal.Id);
            if (result == null)
                throw new Exception("Can not found!");
            await AnimalDAO.UpdateAsync(result);
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

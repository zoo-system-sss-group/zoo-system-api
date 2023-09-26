using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IAnimalRepository
    {
        Task<List<AnimalInformation>> GetAnimalsAsync();
        Task<AnimalInformation?> GetAnimalByIdAsync(int id);
        Task<AnimalInformation?> GetAnimalDietByIdAsync(int id);
        Task AddAnimalsAsync(AnimalInformation animal);
        Task UpdateAnimalAsync(int id, AnimalInformation animal);
        Task SoftDeleteAnimalsAsync(int id);
    }
}

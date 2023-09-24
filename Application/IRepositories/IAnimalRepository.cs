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
        Task<AnimalInformation?> GetAnimalsByIdAsync(int id);
        void AddAnimalsAsync(AnimalInformation animal);
        void UpdateAnimalAsync(AnimalInformation animal);
        void SoftDeleteAnimalsAsync(int id);
    }
}

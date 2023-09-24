using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface ISpeciesRepository
    {
        Task<List<Species>> GetSpeciesAsync();
        Task<Species?> GetSpeciesByIdAsync(int id);
        void AddSpeciesAsync(Species species);
        void UpdateSpeciesAsync(Species species);
        void SoftDeleteSpeciesAsync(int id);
    }
}

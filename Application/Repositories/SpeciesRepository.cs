using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class SpeciesRepository : ISpeciesRepository
    {
        public async Task<List<Species>> GetSpeciesAsync()
            => await SpeciesDAO.GetAllAsync();
        public async Task<Species?> GetSpeciesByIdAsync(int id)
            => await SpeciesDAO.GetByIdAsync(id);
        public async void AddSpeciesAsync(Species species)
            => await SpeciesDAO.SaveAsync(species);
        public async void UpdateSpeciesAsync(int id, Species species)
        {
            var result = await SpeciesDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await SpeciesDAO.UpdateAsync(species);
        }
        public async void SoftDeleteSpeciesAsync(int id)
        {
            var result = await SpeciesDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await SpeciesDAO.SoftDeleteAsync(result);
        }
    }
}

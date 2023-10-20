﻿using Domain.Entities;
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
        Task AddSpeciesAsync(Species species);
        Task UpdateSpeciesAsync(Species species);
        Task SoftDeleteSpeciesAsync(int id);
    }
}

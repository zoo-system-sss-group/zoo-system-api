using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface ICageRepository
    {
        Task<List<Cage>> GetCagesAsync();
        Task<Cage?> GetCageByIdAsync(int id);
        Task AddCageAsync(Cage cage);
        Task UpdateCageAsync(int id, Cage cage);
        Task SoftDeleteCageAsync(int id);
    }
}

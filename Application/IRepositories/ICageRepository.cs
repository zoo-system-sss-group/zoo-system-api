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
        void AddCageAsync(Cage cage);
        void UpdateCageAsync(int id, Cage cage);
        void SoftDeleteCageAsync(int id);
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IDietRepository
    {
        Task<List<Diet>> GetDietsAsync();
        Task<Diet?> GetDietByIdAsync(int id);
        void AddDietAsync(Diet diet);
        void UpdateDietAsync(int id, Diet diet);
        void SoftDeleteDietAsync(int id);
    }
}

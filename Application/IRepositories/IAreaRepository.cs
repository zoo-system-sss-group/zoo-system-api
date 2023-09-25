using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IAreaRepository
    {
        Task<List<Area>> GetAreasAsync();
        Task<Area?> GetAreaByIdAsync(int id);
        void AddAreaAsync(Area area);
        void UpdateAreaAsync(int id, Area area);
        void SoftDeleteAreaAsync(int id);
    }
}

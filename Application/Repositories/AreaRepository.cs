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
    public class AreaRepository : IAreaRepository
    {
        public async Task<List<Area>> GetAreasAsync()
           => await AreaDAO.GetAllAsync();
        public async Task<Area?> GetAreaByIdAsync(int id)
        {
            var area = await AreaDAO.GetByIdAsync(id);
            if (area == null)
                throw new Exception("Can con found!");
            area.Cages = await CageDAO.GetCageByAreaId(id);
            return area;
        }
        public async Task AddAreaAsync(Area area)
            => await AreaDAO.SaveAsync(area);
        public async Task UpdateAreaAsync(int id, Area area)
        {
            var result = await AreaDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await AreaDAO.UpdateAsync(area);
        }
        public async Task SoftDeleteAreaAsync(int id)
        {
            var result = await AreaDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await AreaDAO.SoftDeleteAsync(result);
        }
    }
}

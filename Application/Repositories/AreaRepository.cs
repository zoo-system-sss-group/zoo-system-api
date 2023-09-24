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
            => await AreaDAO.GetByIdAsync(id);
        public async void AddAreaAsync(Area area)
            => await AreaDAO.SaveAsync(area);
        public async void UpdateAreaAsync(Area area)
        {
            var result = await AreaDAO.GetByIdAsync(area.Id);
            if (result == null)
                throw new Exception("Can not found!");
            await AreaDAO.UpdateAsync(result);
        }
        public async void SoftDeleteAreaAsync(int id)
        {
            var result = await AreaDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await AreaDAO.SoftDeleteAsync(result);
        }
    }
}

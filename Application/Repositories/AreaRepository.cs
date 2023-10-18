using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class AreaRepository : IAreaRepository
{
    private readonly AreaDAO _areaDAO;
    private readonly CageDAO _cageDAO;

    public AreaRepository(AreaDAO areaDAO, CageDAO cageDAO)
    {
        _areaDAO = areaDAO;
        _cageDAO = cageDAO;
    }

    public async Task<List<Area>> GetAreasAsync()
       => await _areaDAO.GetAllAsync();

    public async Task<Area?> GetAreaByIdAsync(int id)
    {
        var area = await _areaDAO.GetByIdAsync(id);
        if (area == null)
            throw new Exception("Can con found!");
        area.Cages = await _cageDAO.GetCageByAreaId(id);
        return area;
    }

    public async Task AddAreaAsync(Area area)
        => await _areaDAO.SaveAsync(area);

    public async Task UpdateAreaAsync(int id, Area area)
    {
        var result = await _areaDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        await _areaDAO.UpdateAsync(area);
    }

    public async Task SoftDeleteAreaAsync(int id)
    {
        var result = await _areaDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        await _areaDAO.SoftDeleteAsync(result);
    }
}

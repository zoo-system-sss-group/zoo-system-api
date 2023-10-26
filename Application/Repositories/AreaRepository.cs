﻿using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class AreaRepository : IAreaRepository
{
    private readonly AreaDAO _areaDAO;

    public AreaRepository(AreaDAO areaDAO)
    {
        _areaDAO = areaDAO;
    }

    public IQueryable<Area> GetAreasAsync()
       => _areaDAO.GetAllOdataAsync();

    public IQueryable<Area> GetAreaByIdAsync(int id)
    {
        var area = _areaDAO.GetByIdOdataAsync(id);
        return area;
    }

    public async Task AddAreaAsync(Area area)
        => await _areaDAO.SaveAsync(area);

    public async Task UpdateAreaAsync(Area area)
    {
        // check duplicate code
        var tmp = (await _areaDAO.GetAllAsync())
                .FirstOrDefault(x => x.Code.Equals(area.Code));
        if (tmp != null)
        {
            throw new Exception($"The area code with value '{area.Code}' is duplicated!");
        }

        await _areaDAO.SaveAsync(area);
    }        

    public async Task UpdateAreaAsync(Area area)
    {
        var result = await _areaDAO.GetByIdAsync(area.Id);
        if (result == null)
            throw new Exception("Can not found!");
        area.CreationDate = result.CreationDate;
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

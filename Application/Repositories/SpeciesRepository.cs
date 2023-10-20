using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class SpeciesRepository : ISpeciesRepository
{
    private readonly SpeciesDAO _speciesDAO;

    public SpeciesRepository(SpeciesDAO speciesDAO)
    {
        _speciesDAO = speciesDAO;
    }

    public async Task<List<Species>> GetSpeciesAsync()
        => await _speciesDAO.GetAllAsync();

    public async Task<Species?> GetSpeciesByIdAsync(int id)
        => await _speciesDAO.GetByIdAsync(id);

    public async Task AddSpeciesAsync(Species species)
        => await _speciesDAO.SaveAsync(species);

    public async Task UpdateSpeciesAsync(Species species)
    {
        var result = await _speciesDAO.GetByIdAsync(species.Id);
        if (result == null)
            throw new Exception("Can not found!");
        await _speciesDAO.UpdateAsync(species);
    }

    public async Task SoftDeleteSpeciesAsync(int id)
    {
        var result = await _speciesDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        await _speciesDAO.SoftDeleteAsync(result);
    }
}

using Application.IRepositories;
using Azure;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class CageRepository : ICageRepository
{
    private readonly CageDAO _cageDAO;
    private readonly AnimalDAO _animalDao;

    public CageRepository(CageDAO cageDAO, AnimalDAO animalDao)
    {
        _cageDAO = cageDAO;
        _animalDao = animalDao;
    }

    public async Task<List<Cage>> GetCagesAsync()
        => await _cageDAO.GetAllAsync();

    public async Task<Cage?> GetCageByIdAsync(int id)
    {
        var result = await _cageDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        result.CageHistories = await CageHistoriesDAO.GetListAnimalByCageId(id);
        foreach(CageHistory ch in result.CageHistories)
        {
            ch.Animal = await _animalDao.GetByIdAsync(ch.AnimalId);
        }
        return result;
    }

    public async Task AddCageAsync(Cage cage)
        => await _cageDAO.SaveAsync(cage);

    public async Task UpdateCageAsync(int id, Cage cage)
    {
        var result = await _cageDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        await _cageDAO.UpdateAsync(cage);
    }

    public async Task SoftDeleteCageAsync(int id)
    {
        var result = await _cageDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        await _cageDAO.SoftDeleteAsync(result);
    }
}

using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class DietRepository : IDietRepository
{
    private readonly DietDAO _dietDAO;
    private readonly DietDetailDAO _dietDetailDao;

    public DietRepository(DietDAO dietDAO, DietDetailDAO dietDetailDao)
    {
        _dietDAO = dietDAO;
        _dietDetailDao = dietDetailDao;
    }

    public async Task<List<Diet>> GetDietsAsync()
        => await _dietDAO.GetAllDietsAsync();

    public async Task<Diet?> GetDietByIdAsync(int id)
        => await _dietDAO.GetDietByIdAsync(id);

    public async Task AddDietAsync(Diet diet)
        => await _dietDAO.SaveAsync(diet);
    
    public async Task UpdateDietAsync(Diet diet)
    {
        var result = await _dietDAO.GetByIdAsync(diet.Id);
        if (result == null)
            throw new Exception("Can not found!");
        diet.CreationDate = result.CreationDate;
        await _dietDAO.UpdateAsync(diet);
    }

    public async Task SoftDeleteDietAsync(int id)
    {
        var result = await _dietDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
        await _dietDAO.SoftDeleteAsync(result);
    }
}

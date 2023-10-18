using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class DietRepository : IDietRepository
{
    private readonly DietDAO _dietDAO;

    public DietRepository(DietDAO dietDAO)
    {
        _dietDAO = dietDAO;
    }

    public async Task<List<Diet>> GetDietsAsync()
        => await _dietDAO.GetAllAsync();

    public async Task<Diet?> GetDietByIdAsync(int id)
        => await _dietDAO.GetByIdAsync(id);

    public async Task AddDietAsync(Diet diet)
        => await _dietDAO.SaveAsync(diet);

    public async Task<Diet?> GetCurrentDietByAnimalIdAsync(int id)
    {
        var dietDetail = await DietDetailDAO.GetDietDetailByAnimalId(id);
        return await _dietDAO.GetByIdAsync(dietDetail.DietId);
    } 
    
    public async Task UpdateDietAsync(int id, Diet diet)
    {
        var result = await _dietDAO.GetByIdAsync(id);
        if (result == null)
            throw new Exception("Can not found!");
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

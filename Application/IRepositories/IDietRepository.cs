using Domain.Entities;

namespace Application.IRepositories;

public interface IDietRepository
{
    Task<List<Diet>> GetDietsAsync();
    Task<Diet?> GetDietByIdAsync(int id);
    Task AddDietAsync(Diet diet);
    Task UpdateDietAsync(Diet diet);
    Task SoftDeleteDietAsync(int id);
    Task<Diet?> GetCurrentDietOfAnimalAsync(int animalId);
}

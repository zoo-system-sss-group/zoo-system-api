using Domain.Entities;

namespace Application.IRepositories;

public interface IDietDetailRepository
{
    Task<List<DietDetail>> GetAllDietDetailsAsync();
    Task<DietDetail?> GetDietDetailByIdAsync(int id);
    Task AddDietDetailAsync(DietDetail dietDetail);
    Task UpdateDietDetailAsync(DietDetail dietDetail);
    Task DeleteDietDetailAsync(int id);
}

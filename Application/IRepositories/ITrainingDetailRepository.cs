using Domain.Entities;

namespace Application.IRepositories;

public interface ITrainingDetailRepository
{
    Task<List<TrainingDetail>> GetAllTrainingDetailsAsync();
    Task<TrainingDetail?> GetTrainingDetailByIdAsync(int id);
    Task AddTrainingDetailAsync(TrainingDetail trainingDetail);
    Task UpdateTrainingDetailAsync(TrainingDetail trainingDetail);
    Task DeleteTrainingDetailAsync(int id);
}

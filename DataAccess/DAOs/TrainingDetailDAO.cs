using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class TrainingDetailDAO : BaseDAO<TrainingDetail>
{
    private readonly AppConfiguration _configuration;
    public TrainingDetailDAO(AppConfiguration configuration) : base(configuration)
    {
        _configuration = configuration;
    }
    public async Task<int?> GetCurrentTrainerByAnimalIdAsync(int animalId)
    {
        int? trainerId;
        using (var context = new AppDBContext(_configuration))
        {
            var trainingdetail = await context.TrainingDetails.Where(x => x.AnimalId == animalId && x.EndDate == null).FirstOrDefaultAsync();
            trainerId = trainingdetail.TrainerId;
        }
        return trainerId;
    }

    public async Task<List<TrainingDetail>> GetAllTrainingDetailsAsync()
    {
        var trainingDetails = new List<TrainingDetail>();
        using (var context = new AppDBContext(_configuration))
        {
            trainingDetails = await context.TrainingDetails
                                           .Include(x => x.Trainer)
                                           .Include(x => x.Animal)
                                           .ThenInclude(a => a.DietDetails)
                                           .ToListAsync();
        }
        return trainingDetails;
    }

    public async Task<TrainingDetail?> GetTrainingDetailByIdAsync(int id)
    {
        TrainingDetail? trainingDetail;
        using (var context = new AppDBContext(_configuration))
        {
            trainingDetail = await context.TrainingDetails
                                           .Include(x => x.Trainer)
                                           .Include(x => x.Animal)
                                           .FirstOrDefaultAsync(x => x.Id == id);
        }
        return trainingDetail;
    }
}

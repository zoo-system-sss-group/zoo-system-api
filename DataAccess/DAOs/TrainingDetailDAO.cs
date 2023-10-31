using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
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
    }
}

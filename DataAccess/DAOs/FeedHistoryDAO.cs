using DataAccess.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs
{
    public class FeedHistoryDAO : BaseDAO<FeedHistory>
    {
        private readonly AppConfiguration _configuration;
        public FeedHistoryDAO(AppConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<FeedHistory>> GetTodayFeedHistoriesByAnimalId(int animalId)
        {
            List<FeedHistory> diets;
            using (var context = new AppDBContext(_configuration))
                diets = await context.FeedHistories.Where(x => x.AnimalId == animalId & x.FeedingDate.Date == DateTime.Today.Date).ToListAsync();
            return diets;
        }
        public IQueryable<FeedHistory> GetFeedHistories()
        {
            IQueryable<FeedHistory> diets;
            var context = new AppDBContext(_configuration);
            diets = context.FeedHistories.OrderByDescending(x => x.FeedingDate);
                diets = context.FeedHistories;
            return diets;
        }
    }
}

using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class FeedHistoryRepository : IFeedHistoryRepository
    {
        private readonly FeedHistoryDAO _feedHistoryDAO;
        private readonly TrainingDetailDAO _trainingDetailDAO;

        public FeedHistoryRepository(FeedHistoryDAO feedHistoryDAO, TrainingDetailDAO trainingDetailDAO)
        {
            _feedHistoryDAO = feedHistoryDAO;
            _trainingDetailDAO = trainingDetailDAO;
        }

        public async Task<FeedHistory> GetByIdAsync(int id)
           =>await _feedHistoryDAO.GetByIdAsync(id);

        public async Task<List<FeedHistory>> GetTodayFeedHistoriesByAnimalId(int animalId)
            => await _feedHistoryDAO.GetTodayFeedHistoriesByAnimalId(animalId);
        public async Task AddFeedHistoryAsync(FeedHistory feedHistory)
        {
            await _feedHistoryDAO.SaveAsync(feedHistory);

        }
        public async Task UpdateFeedHistoryAsync(FeedHistory feedHistory)
        {
            var result = await _feedHistoryDAO.GetByIdAsync(feedHistory.Id);
            if (result == null)
                throw new Exception("Can not found!");
            await _feedHistoryDAO.UpdateAsync(feedHistory);
        }
    }
}

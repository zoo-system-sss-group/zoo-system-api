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

        public FeedHistoryRepository(FeedHistoryDAO feedHistoryDAO)
        {
            _feedHistoryDAO = feedHistoryDAO;
        }

        public IQueryable<FeedHistory> GetFeedHistoriesAsync()
           => _feedHistoryDAO.GetAllOdataAsync();

        public IQueryable<FeedHistory> GetFeedHistoryByIdAsync(int id)
        {
            var feedHistories = _feedHistoryDAO.GetByIdOdataAsync(id);
            return feedHistories;
        }

        public async Task AddFeedHistoryAsync(List<FeedHistory> feedHistory)
            => await _feedHistoryDAO.SaveRangeAsync(feedHistory);

        public async Task UpdateFeedHistoryAsync(FeedHistory feedHistory)
        {
            var result = await _feedHistoryDAO.GetByIdAsync(feedHistory.Id);
            if (result == null)
                throw new Exception("Can not found!");
            await _feedHistoryDAO.UpdateAsync(feedHistory);
        }

        public async Task SoftDeleteFeedHistoryAsync(int id)
        {
            var result = await _feedHistoryDAO.GetByIdAsync(id);
            if (result == null)
                throw new Exception("Can not found!");
            await _feedHistoryDAO.SoftDeleteAsync(result);
        }
    }
}

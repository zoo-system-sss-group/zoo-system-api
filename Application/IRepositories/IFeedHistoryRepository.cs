using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IFeedHistoryRepository
    {
        Task<FeedHistory> GetByIdAsync(int id);
        Task AddFeedHistoryAsync(FeedHistory feedHistory);
        Task UpdateFeedHistoryAsync(FeedHistory feedHistory);
        Task<List<FeedHistory>> GetTodayFeedHistoriesByAnimalId(int animalId);
        IQueryable<FeedHistory> GetFeedHistories();
    }
}

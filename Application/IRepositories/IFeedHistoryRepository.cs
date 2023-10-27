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
        IQueryable<FeedHistory> GetFeedHistoriesAsync();
        IQueryable<FeedHistory> GetFeedHistoryByIdAsync(int id);
        Task AddFeedHistoryAsync(List<FeedHistory> feedHistory);
        Task UpdateFeedHistoryAsync(FeedHistory feedHistory);
        Task SoftDeleteFeedHistoryAsync(int id);
    }
}

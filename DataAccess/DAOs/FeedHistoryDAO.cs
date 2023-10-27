using DataAccess.Commons;
using Domain.Entities;

namespace DataAccess.DAOs
{
    public class FeedHistoryDAO : BaseDAO<FeedHistory>
    {
        public FeedHistoryDAO(AppConfiguration configuration) : base(configuration)
        {
        }
    }
}

using Domain.Entities;

namespace Application.Repositories
{
    public interface INewRepository
    {
        Task AddNews(News p);
        Task DeleteNews(News p);
        Task<List<News>> GetNews();
        Task<News?> GetNews(int id);
        Task UpdateNews(News p);
    }
}
using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class NewRepository : INewRepository
{
    public async Task<List<News>> GetNews() => await NewDAO.GetAllAsync();
    public async Task<News?> GetNews(int id) => await NewDAO.GetByIdAsync(id);
    public async Task AddNews(News p) => await NewDAO.SaveAsync(p);
    public async Task UpdateNews(News p) => await NewDAO.UpdateAsync(p);
    public async Task DeleteNews(News p) => await NewDAO.DeleteAsync(p);

}

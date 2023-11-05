using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class DietDetailRepository : IDietDetailRepository
{
    private readonly DietDetailDAO _dietDetailDao;

    public DietDetailRepository(DietDetailDAO dietDetailDAO)
    {
        _dietDetailDao = dietDetailDAO;
    }

    public async Task AddDietDetailAsync(DietDetail dietDetail)
    {
        var tmp = await _dietDetailDao.GetDietDetailByAnimalIdAsync(dietDetail.AnimalId);
        if(tmp != null)
        {
            tmp.EndDate = DateTime.Now;
            await _dietDetailDao.UpdateAsync(tmp);
        }
        await _dietDetailDao.SaveAsync(dietDetail);
    }

    public async Task DeleteDietDetailAsync(int dietDetailId)
    {
        var dietDetail = await _dietDetailDao.GetByIdAsync(dietDetailId);
        if (dietDetail == null)
        {
            throw new ArgumentException("DietDetail Id does not exist.");
        }
        if (dietDetail.IsDeleted)
        {
            throw new ArgumentException("This diet detail has been deleted!");
        }
        await _dietDetailDao.SoftDeleteAsync(dietDetail);
    }

    public async Task<List<DietDetail>> GetAllDietDetailsAsync()
    {
        return await _dietDetailDao.GetAllDietDetailsAsync();
    }

    public async Task<DietDetail?> GetDietDetailByIdAsync(int id)
    {
        return await _dietDetailDao.GetDietDetailByIdAsync(id);
    }

    public async Task UpdateDietDetailAsync(DietDetail dietDetail)
    {
        var tmpdietDetail = await _dietDetailDao.GetByIdAsync(dietDetail.Id);
        if (tmpdietDetail == null)
        {
            throw new ArgumentException("DietDetail Id does not exist.");
        }
        dietDetail.CreationDate = tmpdietDetail.CreationDate;
        await _dietDetailDao.UpdateAsync(dietDetail);
    }
}

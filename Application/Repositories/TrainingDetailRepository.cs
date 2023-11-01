using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace Application.Repositories;

public class TrainingDetailRepository : ITrainingDetailRepository
{
    private readonly TrainingDetailDAO _trainingDetailDAO;
    private readonly AccountDAO _accountDao;
    private readonly AnimalDAO _animalDao;

    public TrainingDetailRepository(TrainingDetailDAO trainingDetailDAO, 
                                    AccountDAO accountDao, AnimalDAO animalDao)
    {
        _trainingDetailDAO = trainingDetailDAO;
        _accountDao = accountDao;
        _animalDao = animalDao;
    }

    public async Task AddTrainingDetailAsync(TrainingDetail trainingDetail)
    {
        var errMessage = "";
        if ((await _accountDao.GetByIdAsync(trainingDetail.TrainerId)) == null)
        {
            errMessage = "Trainer Id not found!";
        }
        if ((await _animalDao.GetByIdAsync(trainingDetail.AnimalId)) == null)
        {
            errMessage += "\n Animal Id not found!";
        }
        if (!errMessage.IsNullOrEmpty())
        {
            throw new Exception(errMessage);
        }

        var tmpTrainingDetail = await _trainingDetailDAO.GetByIdAsync(trainingDetail.Id);
        if (tmpTrainingDetail != null)
        {
            throw new Exception("Duplicate TrainingDetail Id.");
        }
        await _trainingDetailDAO.SaveAsync(trainingDetail);
    }

    public async Task DeleteTrainingDetailAsync(int trainingDetailId)
    {
        var trainingDetail = await _trainingDetailDAO.GetByIdAsync(trainingDetailId);
        if (trainingDetail == null)
        {
            throw new ArgumentException("TrainingDetail Id does not exist.");
        }
        if (trainingDetail.IsDeleted)
        {
            throw new ArgumentException("This training detail has been deleted!");
        }
        await _trainingDetailDAO.SoftDeleteAsync(trainingDetail);
    }

    public async Task<List<TrainingDetail>> GetAllTrainingDetailsAsync()
    {
        return await _trainingDetailDAO.GetAllTrainingDetailsAsync();
    }

    public async Task<TrainingDetail?> GetTrainingDetailByIdAsync(int id)
    {
        return await _trainingDetailDAO.GetTrainingDetailByIdAsync(id);
    }

    public async Task UpdateTrainingDetailAsync(TrainingDetail trainingDetail)
    {
        var tmpTrainingDetail = await _trainingDetailDAO.GetByIdAsync(trainingDetail.Id);
        if (tmpTrainingDetail == null)
        {
            throw new ArgumentException("TrainingDetail Id does not exist.");
        }
        trainingDetail.CreationDate = tmpTrainingDetail.CreationDate;
        await _trainingDetailDAO.UpdateAsync(trainingDetail);
    }

    public IQueryable<TrainingDetail> GetQueryTrainingDetails()
    {
        return  _trainingDetailDAO.GetAllOdataAsync();
    }

    public IQueryable<TrainingDetail> GetQueryTrainingDetailById(int id)
    {
        return _trainingDetailDAO.GetByIdOdataAsync(id);
    }
}

using DataAccess.Commons;
using Domain.Entities;

namespace DataAccess.DAOs;

public class TrainingDetailDAO : BaseDAO<TrainingDetail>
{
    public TrainingDetailDAO(AppConfiguration configuration) : base(configuration)
    {
    }
}

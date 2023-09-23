using Domain.Entities;

namespace Application.IRepositories;

public interface IAccountRepository
{
    Task<Account?> GetAccountByUsernameAsync(string username);
}

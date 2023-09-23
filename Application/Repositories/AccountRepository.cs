using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class AccountRepository : IAccountRepository
{
    public Task<Account?> GetAccountByUsernameAsync(string username)
        => AccountDAO.GetAccountByUsernameAsync(username.Trim());
}

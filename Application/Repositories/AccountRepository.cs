using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly AccountDAO _accountDao;

    public AccountRepository(AccountDAO accountDao)
    {
        _accountDao = accountDao;
    }

    public Task<Account?> GetAccountByUsernameAsync(string username)
        => _accountDao.GetAccountByUsernameAsync(username.Trim());
}

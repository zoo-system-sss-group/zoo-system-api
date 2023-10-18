using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAOs;

public class AccountDAO : BaseDAO<Account>
{
    public async Task<Account?> GetAccountByUsernameAsync(string username)
    {
        Account? account;
        using (var context = new AppDBContext())
        {
            account = await context.Accounts.FirstOrDefaultAsync(x => x.Username.Equals(username));
        }
        return account;
    }
}

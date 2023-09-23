using DataAccess;
using Domain.Entities;
using Domain.Enums;

namespace Application.Utils;

public static class DBInitializer
{
    private static AppDBContext context;
    public static void InitializeData(AppDBContext _context)
    {
        context = _context;
        InitializeAccount();
    }
    public static void InitializeAccount()
    {
        if (context.Accounts.Any())
        {
            return;
        }
        var accounts = new Account[]
        {
            new Account() {Username="staff", Password="123456".Hash(), Fullname="Quản lý cấp cao", Role = RoleEnum.Staff},
            new Account() {Username="trainer", Password="123456".Hash(), Fullname="Huấn luyện viên", Role = RoleEnum.Trainer}
        };
        context.Accounts.AddRange(accounts);
        context.SaveChanges();
    }
}

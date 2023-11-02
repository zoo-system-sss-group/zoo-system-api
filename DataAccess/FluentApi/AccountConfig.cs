using DataAccess.Utils;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class AccountConfig : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasIndex(x => x.Username).IsUnique();
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.ModificationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        builder.HasData
        (
            // trainers
            new Account() { Id = 1, Username = "LionTamer", Password = "123456".Hash(), Fullname = "Lion Tamer",Avatar= "https://i.pinimg.com/564x/be/85/2f/be852fd4ad1cb76b83ce962f618895bd.jpg", Role = RoleEnum.Trainer },
            new Account() { Id = 2, Username = "PachydermPro", Password = "123456".Hash(), Fullname = "Pachyderm Pro",Avatar = "https://i.pinimg.com/564x/ed/de/aa/eddeaaf250c19489e25bd0a2dd3e7756.jpg", Role = RoleEnum.Trainer },
            new Account() { Id = 3, Username = "SharkWhisperer", Password = "123456".Hash(), Fullname = "Shark Whisperer",Avatar = "https://i.pinimg.com/564x/14/b0/3b/14b03bdcab41f458dd15c9f5669cef2d.jpg", Role = RoleEnum.Trainer },
            new Account() { Id = 4, Username = "FoxFriend", Password = "123456".Hash(), Fullname = "Fox Friend",Avatar= "https://i.pinimg.com/564x/6c/a3/4b/6ca34beddfbd279418c915d2258d698b.jpg", Role = RoleEnum.Trainer },
            new Account() { Id = 5, Username = "PenguinPal", Password = "123456".Hash(), Fullname = "Penguin Pal",Avatar = "https://i.pinimg.com/736x/81/3c/57/813c57fcb969d58fac1672594da05532.jpg", Role = RoleEnum.Trainer },
            // staffs
            new Account() { Id = 6, Username = "staff", Password = "123456".Hash(), Fullname = "Nhân viên sở thú", Avatar= "https://i.pinimg.com/564x/7d/cd/61/7dcd61988b0add83b5ba9a656512593e.jpg", Role = RoleEnum.Staff },
            // admin
            new Account() { Id = 7, Username = "admin", Password = "123456".Hash(), Fullname = "Quản trị viên",Avatar= "https://i.pinimg.com/564x/0e/4b/7a/0e4b7aef4834bfc646775d8fd3705825.jpg", Role = RoleEnum.Admin }
        );

    }
}

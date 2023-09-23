using Domain.Entities;
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
    }
}

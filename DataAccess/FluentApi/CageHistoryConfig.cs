using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class CageHistoryConfig : IEntityTypeConfiguration<CageHistory>
{
    public void Configure(EntityTypeBuilder<CageHistory> builder)
    {
        builder.Property(x => x.StartDate).HasDefaultValueSql("getutcdate()");
    }
}

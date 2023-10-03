using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class TicketConfig : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasIndex(x => x.Code).IsUnique();

        builder.Property(x => x.Code).HasDefaultValueSql("newid()");
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");        
    }
}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class TicketOrderConfig : IEntityTypeConfiguration<TicketOrder>
{
    public void Configure(EntityTypeBuilder<TicketOrder> builder)
    {
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");

        // Configure the TicketOrders table to set IDENTITY_INSERT to ON
        builder.Property(x => x.Id)
            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);
    }
}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class TicketTypeConfig : IEntityTypeConfiguration<TicketType>
{
    public void Configure(EntityTypeBuilder<TicketType> builder)
    {
        builder.HasData(
            new TicketType { Code = "A01", Name = "Adult", Price = 100000.0 },
            new TicketType { Code = "C01", Name = "Child", Price = 60000.0 },
            new TicketType { Code = "A02", Name = "VIP Adult", Price = 200000.0 },
            new TicketType { Code = "C02", Name = "VIP Child", Price = 150000.0 }
        );
    }
}

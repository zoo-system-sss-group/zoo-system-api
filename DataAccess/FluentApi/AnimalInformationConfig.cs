using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class AnimalInformationConfig : IEntityTypeConfiguration<AnimalInformation>
{
    public void Configure(EntityTypeBuilder<AnimalInformation> builder)
    {
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.ModificationDate).HasDefaultValueSql("getutcdate()");

        builder.HasOne(x => x.CreatedAccount)
               .WithMany(a => a.AnimalInformations)
               .HasForeignKey(x => x.CreatedBy)
               .OnDelete(DeleteBehavior.Restrict);
    }
}

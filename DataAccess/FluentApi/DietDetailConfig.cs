using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class DietDetailConfig : IEntityTypeConfiguration<DietDetail>
{
    public void Configure(EntityTypeBuilder<DietDetail> builder)
    {
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.ModificationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        #region has init data
        builder.HasData
        (
            // African Lion - Birth Diet
            new DietDetail
            {
                Id = 1,
                AnimalId = 1,
                DietId = 1, // African Lion - Birth Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // Asian Elephant - Mature Diet
            new DietDetail
            {
                Id = 2,
                AnimalId = 2,
                DietId = 5, // Asian Elephant - Mature Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // Great White Shark - Birth Diet
            new DietDetail
            {
                Id = 3,
                AnimalId = 3,
                DietId = 7, // Great White Shark - Birth Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // European Red Fox - Birth Diet
            new DietDetail
            {
                Id = 4,
                AnimalId = 4,
                DietId = 10, // European Red Fox - Birth Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // Emperor Penguin - Mature Diet
            new DietDetail
            {
                Id = 5,
                AnimalId = 5,
                DietId = 14, // Emperor Penguin - Mature Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // Kangaroo - Birth Diet
            new DietDetail
            {
                Id = 6,
                AnimalId = 6,
                DietId = 16, // Kangaroo - Birth Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // Grizzly Bear - Mature Diet
            new DietDetail
            {
                Id = 7,
                AnimalId = 7,
                DietId = 20, // Grizzly Bear - Mature Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // Polar Bear - Birth Diet
            new DietDetail
            {
                Id = 8,
                AnimalId = 8,
                DietId = 22, // Polar Bear - Birth Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // Bengal Tiger - Mature Diet
            new DietDetail
            {
                Id = 9,
                AnimalId = 9,
                DietId = 26, // Bengal Tiger - Mature Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // Panda - Birth Diet
            new DietDetail
            {
                Id = 10,
                AnimalId = 10,
                DietId = 28, // Panda - Birth Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            // Add diet details for the remaining 10 animals, including some with pregnant data
            new DietDetail
            {
                Id = 11,
                AnimalId = 11,
                DietId = 2, // African Lion - Mature Diet (Pregnant)
                StartDate = DateTime.Now,
                EndDate = null
            },
            new DietDetail
            {
                Id = 12,
                AnimalId = 12,
                DietId = 6, // Asian Elephant - Birth Diet (Pregnant)
                StartDate = DateTime.Now,
                EndDate = null
            },
            new DietDetail
            {
                Id = 13,
                AnimalId = 13,
                DietId = 8, // Great White Shark - Mature Diet (Pregnant)
                StartDate = DateTime.Now,
                EndDate = null
            },
            new DietDetail
            {
                Id = 14,
                AnimalId = 14,
                DietId = 12, // European Red Fox - Pregnant Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            new DietDetail
            {
                Id = 15,
                AnimalId = 15,
                DietId = 15, // Emperor Penguin - Pregnant Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            new DietDetail
            {
                Id = 16,
                AnimalId = 16,
                DietId = 18, // Kangaroo - Pregnant Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            new DietDetail
            {
                Id = 17,
                AnimalId = 17,
                DietId = 21, // Grizzly Bear - Pregnant Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            new DietDetail
            {
                Id = 18,
                AnimalId = 18,
                DietId = 24, // Polar Bear - Pregnant Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            new DietDetail
            {
                Id = 19,
                AnimalId = 19,
                DietId = 27, // Bengal Tiger - Pregnant Diet
                StartDate = DateTime.Now,
                EndDate = null
            },
            new DietDetail
            {
                Id = 20,
                AnimalId = 20,
                DietId = 30, // Panda - Pregnant Diet
                StartDate = DateTime.Now,
                EndDate = null
            }
        );
        #endregion


    }
}

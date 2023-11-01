using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class DietConfig : IEntityTypeConfiguration<Diet>
{
    public void Configure(EntityTypeBuilder<Diet> builder)
    {
        builder.Property(x => x.CreationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.ModificationDate).HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        #region has init data
        builder.HasData
        (
            // African Lion
            new Diet
            {
                Id = 1,
                DietName = "African Lion - Birth Diet",
                FoodName = "Milk",
                Quantity = 0.5,
                Unit = "liters",
                TimesPerDay = 8
            },
            new Diet
            {
                Id = 2,
                DietName = "African Lion - Mature Diet",
                FoodName = "Meat and vegetables",
                Quantity = 2.0,
                Unit = "kilograms",
                TimesPerDay = 2
            },
            new Diet
            {
                Id = 3,
                DietName = "African Lion - Pregnant Diet",
                FoodName = "Special pregnancy diet",
                Quantity = 2.5,
                Unit = "kilograms",
                TimesPerDay = 3
            },

            // Asian Elephant
            new Diet
            {
                Id = 4,
                DietName = "Asian Elephant - Birth Diet",
                FoodName = "Milk and Vegetables",
                Quantity = 5.0, // Adjusted for milk and baby food
                Unit = "liters",
                TimesPerDay = 4
            },
            new Diet
            {
                Id = 5,
                DietName = "Asian Elephant - Mature Diet",
                FoodName = "Grasses, Fruits, Vegetables, and Sugarcane",
                Quantity = 150.0,
                Unit = "kilograms",
                TimesPerDay = 3
            },
            new Diet
            {
                Id = 6,
                DietName = "Asian Elephant - Pregnant Diet",
                FoodName = "Special pregnancy diet (Extra Fruits, Vegetables, and Sugarcane)",
                Quantity = 150.0,
                Unit = "kilograms",
                TimesPerDay = 3
            },

            // Great White Shark
            new Diet
            {
                Id = 7,
                DietName = "Great White Shark - Birth Diet",
                FoodName = "Fish and other small sea creatures",
                Quantity = 10.0,
                Unit = "kilograms",
                TimesPerDay = 3
            },
            new Diet
            {
                Id = 8,
                DietName = "Great White Shark - Mature Diet",
                FoodName = "Seals, sea lions, fish, and other sharks",
                Quantity = 30.0,
                Unit = "kilograms",
                TimesPerDay = 2
            },
            new Diet
            {
                Id = 9,
                DietName = "Great White Shark - Pregnant Diet",
                FoodName = "Special pregnancy diet (Extra Fish and Sea Creatures)",
                Quantity = 40.0,
                Unit = "kilograms",
                TimesPerDay = 3
            },

            // European Red Fox
            new Diet
            {
                Id = 10,
                DietName = "European Red Fox - Birth Diet",
                FoodName = "Milk and Small Creatures",
                Quantity = 0.5,
                Unit = "liters",
                TimesPerDay = 4
            },
            new Diet
            {
                Id = 11,
                DietName = "European Red Fox - Mature Diet",
                FoodName = "Small mammals, birds, fruits, and insects",
                Quantity = 2.0,
                Unit = "kilograms",
                TimesPerDay = 2
            },
            new Diet
            {
                Id = 12,
                DietName = "European Red Fox - Pregnant Diet",
                FoodName = "Special pregnancy diet (Extra Small Creatures and Fruits)",
                Quantity = 2.5,
                Unit = "kilograms",
                TimesPerDay = 3
            },

            // Emperor Penguin
            new Diet
            {
                Id = 13,
                DietName = "Emperor Penguin - Birth Diet",
                FoodName = "Milk and Fish",
                Quantity = 0.5,
                Unit = "liters",
                TimesPerDay = 8
            },
            new Diet
            {
                Id = 14,
                DietName = "Emperor Penguin - Mature Diet",
                FoodName = "Fish, squid, and krill",
                Quantity = 2.0,
                Unit = "kilograms",
                TimesPerDay = 2
            },
            new Diet
            {
                Id = 15,
                DietName = "Emperor Penguin - Pregnant Diet",
                FoodName = "Special pregnancy diet (Extra Fish and Seafood)",
                Quantity = 2.5,
                Unit = "kilograms",
                TimesPerDay = 3
            },

            // Kangaroo
            new Diet
            {
                Id = 16,
                DietName = "Kangaroo - Birth Diet",
                FoodName = "Milk and Grasses",
                Quantity = 0.5,
                Unit = "liters",
                TimesPerDay = 8
            },
            new Diet
            {
                Id = 17,
                DietName = "Kangaroo - Mature Diet",
                FoodName = "Grasses and plants",
                Quantity = 2.0,
                Unit = "kilograms",
                TimesPerDay = 2
            },
            new Diet
            {
                Id = 18,
                DietName = "Kangaroo - Pregnant Diet",
                FoodName = "Special pregnancy diet (Extra Grasses and Leaves)",
                Quantity = 2.5,
                Unit = "kilograms",
                TimesPerDay = 3
            },

            // Grizzly Bear
            new Diet
            {
                Id = 19,
                DietName = "Grizzly Bear - Birth Diet",
                FoodName = "Milk and Berries",
                Quantity = 2.0,
                Unit = "liters",
                TimesPerDay = 4
            },
            new Diet
            {
                Id = 20,
                DietName = "Grizzly Bear - Mature Diet",
                FoodName = "Fish, berries, roots, and small mammals",
                Quantity = 5.0,
                Unit = "kilograms",
                TimesPerDay = 3
            },
            new Diet
            {
                Id = 21,
                DietName = "Grizzly Bear - Pregnant Diet",
                FoodName = "Special pregnancy diet (Extra Berries and Small Creatures)",
                Quantity = 6.0,
                Unit = "kilograms",
                TimesPerDay = 4
            },

            // Polar Bear
            new Diet
            {
                Id = 22,
                DietName = "Polar Bear - Birth Diet",
                FoodName = "Milk and Fish",
                Quantity = 1.0,
                Unit = "liters",
                TimesPerDay = 6
            },
            new Diet
            {
                Id = 23,
                DietName = "Polar Bear - Mature Diet",
                FoodName = "Seals and fish",
                Quantity = 4.0,
                Unit = "kilograms",
                TimesPerDay = 2
            },
            new Diet
            {
                Id = 24,
                DietName = "Polar Bear - Pregnant Diet",
                FoodName = "Special pregnancy diet (Extra Fish and Seafood)",
                Quantity = 5.0,
                Unit = "kilograms",
                TimesPerDay = 3
            },

            // Bengal Tiger
            new Diet
            {
                Id = 25,
                DietName = "Bengal Tiger - Birth Diet",
                FoodName = "Milk and Meat",
                Quantity = 0.5,
                Unit = "liters",
                TimesPerDay = 8
            },
            new Diet
            {
                Id = 26,
                DietName = "Bengal Tiger - Mature Diet",
                FoodName = "Deer, wild boar, and other ungulates",
                Quantity = 2.0,
                Unit = "kilograms",
                TimesPerDay = 2
            },
            new Diet
            {
                Id = 27,
                DietName = "Bengal Tiger - Pregnant Diet",
                FoodName = "Special pregnancy diet (Extra Meat and Prey)",
                Quantity = 2.5,
                Unit = "kilograms",
                TimesPerDay = 3
            },

            // Panda
            new Diet
            {
                Id = 28,
                DietName = "Panda - Birth Diet",
                FoodName = "Milk and Bamboo",
                Quantity = 0.5,
                Unit = "liters",
                TimesPerDay = 8
            },
            new Diet
            {
                Id = 29,
                DietName = "Panda - Mature Diet",
                FoodName = "Bamboo shoots and leaves",
                Quantity = 2.0,
                Unit = "kilograms",
                TimesPerDay = 2
            },
            new Diet
            {
                Id = 30,
                DietName = "Panda - Pregnant Diet",
                FoodName = "Special pregnancy diet (Extra Bamboo and Vegetation)",
                Quantity = 2.5,
                Unit = "kilograms",
                TimesPerDay = 3
            }
        );
        #endregion

    }
}

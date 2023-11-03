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
        builder.Property(x => x.IsDeleted).HasDefaultValue(false);

        #region has init data
        builder.HasData
        (
            new AnimalInformation()
            {
                Id = 1,
                Name = "Simba",
                Image = "https://i.pinimg.com/564x/db/40/00/db40008ec6c5e2d789834f67359eee44.jpg",
                Description = "Majestic African lion named Simba.",
                Weight = 180,
                BirthDate = DateTime.Parse("2018-04-15"),
                SpeciesId = 1 // African Lion
            },
            new AnimalInformation()
            {
                Id = 2,
                Name = "Dumbo",
                Description = "Gentle Asian elephant named Dumbo.",
                Image = "https://i.pinimg.com/564x/1c/d5/9d/1cd59d96db28e0cbf5e88270bac8fb34.jpg",
                Weight = 4500,
                Height = 10.0,
                BirthDate = DateTime.Parse("2015-07-20"),
                SpeciesId = 2 // Asian Elephant
            },
            new AnimalInformation()
            {
                Id = 3,
                Name = "Jaws",
                Image = "https://i.pinimg.com/564x/fb/b9/fb/fbb9fb9a5f8f9f2d4244ad7c2bb1b6fe.jpg",
                Description = "Fearsome great white shark named Jaws.",
                Weight = 2000,
                BirthDate = DateTime.Parse("2017-02-10"),
                SpeciesId = 3 // Great White Shark
            },
            new AnimalInformation()
            {
                Id = 4,
                Name = "Foxy",
                Image = "https://i.pinimg.com/564x/9c/ee/58/9cee58f97470496aa9b99ac613125a5c.jpg",
                Description = "Cunning European red fox named Foxy.",
                Weight = 10,
                BirthDate = DateTime.Parse("2020-09-30"),
                SpeciesId = 4 // European Red Fox
            },
            new AnimalInformation()
            {
                Id = 5,
                Name = "Emmy",
                Description = "Regal emperor penguin named Emmy.",
                Image = "https://i.pinimg.com/564x/ae/3c/24/ae3c24f7dbd9e9ba721a3b76fec1c32b.jpg",
                Weight = 35,
                BirthDate = DateTime.Parse("2019-12-05"),
                SpeciesId = 5 // Emperor Penguin
            },
            new AnimalInformation()
            {
                Id = 6,
                Name = "Kang",
                Description = "Energetic kangaroo named Kang.",
                Image = "https://i.pinimg.com/564x/5a/4c/15/5a4c15238fce3e4e1c5405965c1a7237.jpg",
                Weight = 70,
                BirthDate = DateTime.Parse("2017-11-12"),
                SpeciesId = 6 // Kangaroo
            },
            new AnimalInformation()
            {
                Id = 7,
                Name = "Bear",
                Description = "Majestic grizzly bear named Bear.",
                Image = "https://i.pinimg.com/564x/7a/51/b9/7a51b95ffc4d7cbac381c30cc5fbe077.jpg",
                Weight = 800,
                Height = 5.0,
                BirthDate = DateTime.Parse("2016-03-25"),
                SpeciesId = 7 // Grizzly Bear
            },
            new AnimalInformation()
            {
                Id = 8,
                Name = "Nanook",
                Description = "Proud polar bear named Nanook.",
                Image = "https://i.pinimg.com/564x/0c/6c/eb/0c6ceb9b063baff86c11b7e1f696bf04.jpg",
                Weight = 900,
                Height = 4.5,
                BirthDate = DateTime.Parse("2015-12-18"),
                SpeciesId = 8 // Polar Bear
            },
            new AnimalInformation()
            {
                Id = 9,
                Name = "Raja",
                Description = "Fierce Bengal tiger named Raja.",
                Weight = 200,
                Image = "https://i.pinimg.com/564x/52/91/cf/5291cf756d15a62f4b8b717e154ca37e.jpg",
                Height = 3.0,
                BirthDate = DateTime.Parse("2016-06-09"),
                SpeciesId = 9 // Bengal Tiger
            },
            new AnimalInformation()
            {
                Id = 10,
                Name = "Pandy",
                Description = "Adorable panda named Pandy.",
                Image = "https://i.pinimg.com/564x/99/bf/a4/99bfa449a463241b88739980663738d0.jpg",
                Weight = 150,
                Height = 2.0,
                BirthDate = DateTime.Parse("2017-08-30"),
                SpeciesId = 10 // Panda
            },
            new AnimalInformation()
            {
                Id = 11,
                Name = "Zara",
                Description = "Graceful African lioness named Zara.",
                Image = "https://i.pinimg.com/564x/4e/26/37/4e26371ca9dfefc559fff95d041d911b.jpg",
                Weight = 150,
                BirthDate = DateTime.Parse("2019-02-14"),
                SpeciesId = 1 // African Lion
            },
            new AnimalInformation()
            {
                Id = 12,
                Name = "Babar",
                Description = "Gentle Asian elephant named Babar.",
                Image = "https://i.pinimg.com/564x/77/f9/6c/77f96c07e4682b864bd8c1815da37aa7.jpg",
                Weight = 4000,
                Height = 9.5,
                BirthDate = DateTime.Parse("2016-10-12"),
                SpeciesId = 2 // Asian Elephant
            },
            new AnimalInformation()
            {
                Id = 13,
                Name = "Fins",
                Description = "Majestic great white shark named Fins.",
                Image = "https://i.pinimg.com/564x/bb/81/9e/bb819e828e69a7b74d0efec858df28ff.jpg",
                Weight = 1800,
                BirthDate = DateTime.Parse("2018-07-28"),
                SpeciesId = 3 // Great White Shark
            },
            new AnimalInformation()
            {
                Id = 14,
                Name = "Sly",
                Description = "Clever European red fox named Sly.",
                Image = "https://i.pinimg.com/564x/a1/af/f6/a1aff62d5b61c8ff2d9fd1128f4ae8c7.jpg",
                Weight = 12,
                BirthDate = DateTime.Parse("2021-04-03"),
                SpeciesId = 4 // European Red Fox
            },
            new AnimalInformation()
            {
                Id = 15,
                Name = "Waddle",
                Description = "Charming emperor penguin named Waddle.",
                Image = "https://i.pinimg.com/564x/5b/a3/b2/5ba3b2ac8ca269f8c111255b03ee2224.jpg",
                Weight = 30,
                BirthDate = DateTime.Parse("2020-01-12"),
                SpeciesId = 5 // Emperor Penguin
            },
            new AnimalInformation()
            {
                Id = 16,
                Name = "Joey",
                Description = "Energetic kangaroo named Joey.",
                Image= "https://i.pinimg.com/736x/cb/86/34/cb8634141686341ac17d6a99b0ec4d5d.jpg",
                Weight = 75,
                BirthDate = DateTime.Parse("2017-08-15"),
                SpeciesId = 6 // Kangaroo
            },
            new AnimalInformation()
            {
                Id = 17,
                Name = "Bearly",
                Description = "Playful grizzly bear cub named Bearly.",
                Image = "https://i.pinimg.com/564x/25/10/b7/2510b768ba2867870004f6a05f3a8484.jpg",
                Weight = 150,
                Height = 2.5,
                BirthDate = DateTime.Parse("2022-03-10"),
                SpeciesId = 7 // Grizzly Bear
            },
            new AnimalInformation()
            {
                Id = 18,
                Name = "Snowy",
                Description = "Young polar bear named Snowy.",
                Image = "https://i.pinimg.com/564x/05/b5/41/05b541cd74e53a88bc086a841727cf92.jpg",
                Weight = 300,
                Height = 3.0,
                BirthDate = DateTime.Parse("2020-12-01"),
                SpeciesId = 8 // Polar Bear
            },
            new AnimalInformation()
            {
                Id = 19,
                Name = "Tyga",
                Description = "Adventurous Bengal tiger cub named Tyga.",
                Image = "https://i.pinimg.com/564x/ea/b4/67/eab467dd41563c6658fec4a730f78e90.jpg",
                Weight = 50,
                Height = 2.0,
                BirthDate = DateTime.Parse("2022-06-25"),
                SpeciesId = 9 // Bengal Tiger
            },
            new AnimalInformation()
            {
                Id = 20,
                Name = "Bamboo",
                Description = "Bamboo-loving panda named Bamboo.",
                Image = "https://i.pinimg.com/564x/86/e0/33/86e03347fd80983cc6a19bfe75d49620.jpg",
                Weight = 120,
                Height = 1.5,
                BirthDate = DateTime.Parse("2019-09-05"),
                SpeciesId = 10 // Panda
            }
        );

        #endregion

    }
}

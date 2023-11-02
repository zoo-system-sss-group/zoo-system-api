using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi;

public class CageConfig : IEntityTypeConfiguration<Cage>
{
    public void Configure(EntityTypeBuilder<Cage> builder)
    {
        #region has init data
        builder.HasData
        (
            new Cage()
            {
                Id = 1,
                Code = "A0001",
                Name = "African Safari",
                Location = "Savannah Exhibit",
                Capacity = 10,
                Description = "A spacious exhibit featuring African animals.",
                AreaId = 1,// Assume it's in Area 1

                Image = "https://i.pinimg.com/736x/7e/90/d7/7e90d7179d7c55a5f8a9f868d00b1b7a.jpg"
            },
            new Cage()
            {
                Id = 2,
                Code = "A0002",
                Name = "Elephant Sanctuary",
                Location = "Asian Elephant Pavilion",
                Capacity = 15,
                Image = "https://i.pinimg.com/736x/6c/16/68/6c166887958e66c8e3b01a7e84a425b7.jpg",
                Description = "A dedicated area for Asian elephants.",
                AreaId = 1 // Assume it's in Area 1
            },
            new Cage()
            {
                Id = 3,
                Code = "B0003",
                Name = "Shark Tank",
                Location = "Marine World",
                Image = "https://i.pinimg.com/736x/3e/cb/a3/3ecba328f8dff176289a8d3fd9d81059.jpg",
                Capacity = 12,
                Description = "A large tank showcasing great white sharks.",
                AreaId = 2 // Assume it's in Area 2
            },
            new Cage()
            {
                Id = 4,
                Code = "B0004",
                Name = "Grizzly Wilderness",
                Location = "North American Habitat",
                Image = "https://i.pinimg.com/236x/6d/d2/62/6dd26201a3938ca84937edbc98531d66.jpg",

                Capacity = 20,
                Description = "A natural habitat for grizzly bears.",
                AreaId = 2 // Assume it's in Area 2
            },
            new Cage()
            {
                Id = 5,
                Code = "C0005",
                Name = "Penguin Paradise",
                Location = "Antarctic Exhibit",
                Image = "https://i.pinimg.com/736x/b9/c3/d3/b9c3d39666b871e2ab805c71c0747be4.jpg",

                Capacity = 8,
                Description = "A chilly paradise for emperor penguins.",
                AreaId = 3 // Assume it's in Area 3
            },
            new Cage()
            {
                Id = 6,
                Code = "A0006",
                Name = "African Plains",
                Location = "Wide Open Savannah",Image= "https://i.pinimg.com/736x/fe/4b/2a/fe4b2aee3aa2d9339c70e901bb67e4f0.jpg",
                Capacity = 20,
                Description = "A vast exhibit showcasing African wildlife.",
                AreaId = 1 // Assume it's in Area 1
            },
            new Cage()
            {
                Id = 7,
                Code = "B0007",
                Name = "Polar Icecaps",
                Location = "Arctic Enclosure",
                Image = "https://i.pinimg.com/736x/54/f0/b1/54f0b14281c56c4933a43dbcda2efbbe.jpg",
                Capacity = 18,
                Description = "A chilly environment for polar animals.",
                AreaId = 2 // Assume it's in Area 2
            },
            new Cage()
            {
                Id = 8,
                Code = "C0008",
                Name = "Aussie Outback",
                Location = "Australian Habitat",Image= "https://i.pinimg.com/736x/24/93/01/24930132c3e7bb452e2e49cef68f4e56.jpg",
                Capacity = 12,
                Description = "An arid landscape for Australian fauna.",
                AreaId = 3 // Assume it's in Area 3
            },
            new Cage()
            {
                Id = 9,
                Code = "D0009",
                Name = "Siberian Taiga",
                Location = "Russian Wilderness",Image= "https://i.pinimg.com/736x/18/fd/af/18fdaf68d166b9911cca446adb0f3f58.jpg",
                Capacity = 15,
                Description = "A dense forest for Siberian wildlife.",
                AreaId = 4 // Assume it's in Area 4
            },
            new Cage()
            {
                Id = 10,
                Code = "E0010",
                Name = "Amazon Rainforest",
                Location = "South American Jungle",
                Image= "https://i.pinimg.com/736x/4d/af/35/4daf352008585dc28fe1790e4f5245ac.jpg",
                Capacity = 25,
                Description = "A lush jungle exhibit for Amazon species.",
                AreaId = 5 // Assume it's in Area 5
            }
        );

        #endregion

    }
}

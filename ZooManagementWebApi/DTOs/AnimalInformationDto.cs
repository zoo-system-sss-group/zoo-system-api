using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagementWebApi.DTOs
{
    public class AnimalInformationDto
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public byte[]? Image { get; set; }
        public DateTime BirthDate { get; set; }
        public int SpeciesId { get; set; }
        [NotMapped]
        public List<CageHistoryDto> CageHistories { get; set; } = new List<CageHistoryDto>();
    }
}

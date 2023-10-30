using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagementWebApi.DTOs
{
    public class AnimalInformationDto
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        [Range(0, double.MaxValue, ErrorMessage = "Weight must be a non-negative number")]
        public double? Weight { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Height must be a non-negative number")]
        public double? Height { get; set; }
        public byte[]? Image { get; set; }
        public DateTime BirthDate { get; set; }
        public int SpeciesId { get; set; }
        [NotMapped]
        public List<CageHistoryDto> CageHistories { get; set; } = new List<CageHistoryDto>();
    }
}

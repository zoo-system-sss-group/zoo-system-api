using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagementWebApi.DTOs
{
    public class AnimalInformationDto
    {
        [Required(ErrorMessage = "Animal name is required!")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; } = default!;
        [Range(0, double.MaxValue, ErrorMessage = "Weight must be a non-negative number")]
        public double? Weight { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Height must be a non-negative number")]
        public double? Height { get; set; }
        public string? Image { get; set; }
        public DateTime BirthDate { get; set; }
        public int SpeciesId { get; set; }
        public CageHistoryDto CageHistory { get; set; } = null;
    }
}

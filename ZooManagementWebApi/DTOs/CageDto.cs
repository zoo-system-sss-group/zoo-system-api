using System.ComponentModel.DataAnnotations;

namespace ZooManagementWebApi.DTOs
{
    public class CageDto
    {
        [Required(ErrorMessage = "Code is required!")]
        public string Code { get; set; } = default!;
        [Required(ErrorMessage = "Cage name is required!")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Location is required!")]
        public string Location { get; set; } = default!;
        public string? Image { get; set; }
        [Required(ErrorMessage = "Capacity is required!")]
        public int Capacity { get; set; }
        public string? Description { get; set; }
        public int AreaId { get; set; }
    }
}

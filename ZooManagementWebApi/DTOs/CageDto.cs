namespace ZooManagementWebApi.DTOs
{
    public class CageDto
    {
        public string Code { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Location { get; set; } = default!;
        public byte[]? Image { get; set; }
        public int Capacity { get; set; }
        public string? Description { get; set; }
        public int AreaId { get; set; }
    }
}

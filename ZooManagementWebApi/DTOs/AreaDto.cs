namespace ZooManagementWebApi.DTOs
{
    public class AreaDto
    {
        public string Code { get; set; } = default!; // A,B,C
        public string Name { get; set; } = default!;
        public string Location { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int Capacity { get; set; }
    }
}

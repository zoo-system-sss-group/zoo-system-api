namespace ZooManagementWebApi.DTOs
{
    public class CageHistoryDto
    {
        public int CageId { get; set; }
        public int AnimalId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
    }
}

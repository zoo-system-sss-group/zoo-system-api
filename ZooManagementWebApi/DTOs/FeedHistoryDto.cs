namespace ZooManagementWebApi.DTOs
{
    public class FeedHistoryDto
    {
        public int TrainerId { get; set; }
        public int AnimalId { get; set; }
        public DateTime FeedingDate { get; set; } = DateTime.Now;
    }
}

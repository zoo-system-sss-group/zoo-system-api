namespace Domain.Entities;

public class FeedHistory : BaseEntity
{
    public int TrainerId { get; set; }
    public int AnimalId { get; set; }
    public DateTime FeedingDate { get; set; } = DateTime.Now;

    public int? DietId { get; set; }

    public Account Trainer { get; set; } = default!;
    public AnimalInformation Animal { get; set; } = default!;
    public Diet? Diet { get; set; }
}

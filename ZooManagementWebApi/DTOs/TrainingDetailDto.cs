namespace ZooManagementWebApi.DTOs;

public class TrainingDetailDto
{
    public int TrainerId { get; set; }
    public int AnimalId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}

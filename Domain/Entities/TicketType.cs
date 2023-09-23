namespace Domain.Entities;

public class TicketType : BaseEntity
{
    public string Name { get; set; } = default!;
    public double Price { get; set; }
}

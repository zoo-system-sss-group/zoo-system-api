namespace Domain.Entities;

public class Ticket : BaseEntity
{
    public Guid Code { get; set; } = Guid.NewGuid();
    public double Price { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime EffectiveDate { get; set; }
    public string TypeCode { get; set; } = default!;
    public int? OrderId { get; set; }

    public TicketType Type { get; set; } = default!;
    public TicketOrder? OrderInformation { get; set; }
}

using Domain.Enums;

namespace Domain.Entities;

public class TicketOrder : BaseEntity
{
    public string CustomerName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public DateTime PurchaseDate { get; set; }
    public PaymentEnum PaymentMethod { get; set; }
    public double Total { get; set; }

    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}

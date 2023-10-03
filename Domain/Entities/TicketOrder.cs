using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Entities;

public class TicketOrder : BaseEntity
{
    public string CustomerName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public PaymentEnum PaymentMethod { get; set; }
    public double Total { get; set; } = 0;
    public byte Status { get; set; } = 1;

    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}

using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class TicketType
{
    [Key]
    public string Code { get; set; } = default!; // Format: A01, C01, A02, C02
    public string Name { get; set; } = default!;
    public double Price { get; set; }
}

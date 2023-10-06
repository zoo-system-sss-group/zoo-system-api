using Domain.Enums;

namespace ZooManagementWebApi.DTOs;

public class TicketOrderUpdateDTO
{
    public string CustomerName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public PaymentEnum PaymentMethod { get; set; } = default!;
    public byte Status { get; set; }
}

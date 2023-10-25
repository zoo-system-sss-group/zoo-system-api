using Domain.Enums;

namespace ZooManagementWebApi.DTOs;

public class TicketCreateDto
{
    public TicketTypeEnum TicketType { get; set; }
    public int Quantity { get; set; } = 1;
}

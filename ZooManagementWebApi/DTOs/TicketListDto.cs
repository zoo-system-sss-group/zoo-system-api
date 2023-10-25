namespace ZooManagementWebApi.DTOs;

public class TicketListDto
{
    public List<TicketCreateDto> Tickets { get; set; } = new List<TicketCreateDto>();
}

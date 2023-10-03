using Domain.Entities;

namespace ZooManagementWebApi.DTOs;

public class TicketViewDTO
{
    public int Id { get; set; }
    public Guid Code { get; set; }
    public double Price { get; set; }    
    public DateTime EffectiveDate { get; set; }
    public TicketType TicketType { get; set; } = default!;
    public bool IsActive { get; set; }
}

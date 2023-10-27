using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagementWebApi.DTOs;

public class TicketOrderDto
{
    [Required]
    public string CustomerName { get; set; } = default!;

    public string? Email { get; set; }

    [Phone]
    [Required]
    public string PhoneNumber { get; set; } = default!;
    
    public DateTime EffectiveDate { get; set; } // Vé cho hôm nào
    [EnumDataType(typeof(PaymentEnum))]

    public PaymentEnum PaymentMethod { get; set; }

    [NotMapped]
    public List<TicketCreateDto> Tickets { get; set; } = new List<TicketCreateDto>();
}

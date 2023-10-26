using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagementWebApi.DTOs;

public class TicketOrderDto
{
    public string CustomerName { get; set; } = default!;

    public string Email { get; set; } = default!;

    [MinLength(10, ErrorMessage = "Phone number at least 10 digits.")]
    public string PhoneNumber { get; set; } = default!;

    public DateTime EffectiveDate { get; set; } // Vé cho hôm nào

    public PaymentEnum PaymentMethod { get; set; }

    [NotMapped]
    public List<TicketCreateDto> Tickets { get; set; } = new List<TicketCreateDto>();
}

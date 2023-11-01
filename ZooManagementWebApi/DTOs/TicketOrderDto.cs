using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagementWebApi.DTOs;

public class TicketOrderDto
{
    [Required(ErrorMessage = "Customer name is required!")]
    public string CustomerName { get; set; } = default!;

    [Required(ErrorMessage = "Email is required!")]
    [EmailAddress]
    public string Email { get; set; } = default!;

    [Phone]    
    [Required(ErrorMessage = "Phone number is required!")]
    [MinLength(10, ErrorMessage = "Phone number at least 10 digits.")]
    public string PhoneNumber { get; set; } = default!;
    
    public DateTime EffectiveDate { get; set; } // Vé cho hôm nào

    [EnumDataType(typeof(PaymentEnum))]
    public PaymentEnum PaymentMethod { get; set; } = PaymentEnum.Card;


    [EnumDataType(typeof(OrderStatusEnum))]
    public OrderStatusEnum? Status { get; set; } = OrderStatusEnum.Waiting;

    [NotMapped]
    public List<TicketCreateDto> Tickets { get; set; } = new List<TicketCreateDto>();
}

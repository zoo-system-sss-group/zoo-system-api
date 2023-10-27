﻿using Domain.Enums;

namespace Domain.Entities;

public class TicketOrder : BaseEntity
{
    public Guid Code { get; set; } = Guid.NewGuid();

    public string CustomerName { get; set; } = default!;
    [EmailAddress]
    public string? Email { get; set; }
    
<<<<<<< Updated upstream
    public string Email { get; set; } = default!;
    
    public string PhoneNumber { get; set; } = default!;

    public DateTime EffectiveDate { get; set; }
=======
    [Phone]
    public string PhoneNumber { get; set; } = default!;
    public DateTime EffectiveDate { get; set; } // Vé cho hôm nào
>>>>>>> Stashed changes

    public PaymentEnum PaymentMethod { get; set; }
    
    public double TotalMoney { get; set; } = 0;
    
    public int TotalTicket { get; set; } = 0;
    [EnumDataType(typeof(OrderStatusEnum))]

    public OrderStatusEnum Status { get; set; } = OrderStatusEnum.Waiting;

    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}

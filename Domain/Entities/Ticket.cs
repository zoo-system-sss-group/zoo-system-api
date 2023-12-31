﻿using Domain.Enums;

namespace Domain.Entities;

public class Ticket : BaseEntity
{
    public Guid Code { get; set; } = Guid.NewGuid();
    
    public double Price { get; set; }
    
    public bool IsActive { get; set; } = true;

    public TicketTypeEnum TicketType { get; set; }

    public int OrderId { get; set; }

    public TicketOrder OrderInformation { get; set; } = default!;
}

using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class TicketOrderRepository : ITicketOrderRepository
{
    private readonly TicketOrderDAO _ticketOrderDAO;

    public TicketOrderRepository(TicketOrderDAO ticketOrderDAO)
    {
        _ticketOrderDAO = ticketOrderDAO;
    }

    public async Task AddTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await _ticketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder != null)
        {
            throw new Exception("Duplicate TicketOrder Id.");
        }

        if ((order.EffectiveDate - DateTime.Today).TotalDays <= 0 
            || (order.EffectiveDate - DateTime.Today).TotalDays > 30)
        {
            throw new Exception("Invalid effective date! " +
                "You can only buy tickets for at least 1 day and maximum for 30 days in advance from the current date");
        }
        await _ticketOrderDAO.SaveAsync(order);
    }

    public async Task DeleteTicketOrderAsync(int orderId)
    {
        var order = await _ticketOrderDAO.GetTicketOrderByIdAsync(orderId);
        if (order == null)
        {
            throw new ArgumentException("TicketOrder Id does not exist.");
        }
        await _ticketOrderDAO.SoftDeleteAsync(order);
    }

    public async Task<List<TicketOrder>> GetAllTicketOrdersAsync()
    {
        return await _ticketOrderDAO.GetAllTicketOrdersAsync();
    }        

    public async Task<TicketOrder?> GetTicketOrderByIdAsync(int id)
    {
        return await _ticketOrderDAO.GetTicketOrderByIdAsync(id);
    }        

    public async Task SoftDeleteTicketOrderAsync(int orderId)
    {
        var order = await _ticketOrderDAO.GetTicketOrderByIdAsync(orderId);
        if (order == null)
        {
            throw new ArgumentException("TicketOrder Id does not exist.");
        }
        await _ticketOrderDAO.SoftDeleteAsync(order);
    }

    public async Task UpdateTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await _ticketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder == null)
        {
            throw new ArgumentException("TicketOrder Id does not exist.");
        }
        order.CreationDate = tmpTicketOrder.CreationDate;
        order.TotalMoney = tmpTicketOrder.TotalMoney;
        order.TotalTicket = tmpTicketOrder.TotalTicket;
        await _ticketOrderDAO.UpdateAsync(order);
    }
}

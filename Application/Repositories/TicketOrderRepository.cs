using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class TicketOrderRepository : ITicketOrderRepository
{
    public async Task AddTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await TicketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder != null)
        {
            throw new Exception("Duplicate TicketOrder Id.");
        }
        else
        {
            await TicketOrderDAO.SaveAsync(order);
        }
    }

    public async Task DeleteTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await TicketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder == null)
        {
            throw new Exception("TicketOrder Id does not exist.");
        }
        else
        {
            await TicketOrderDAO.DeleteAsync(order);
        }
    }

    public async Task<List<TicketOrder>> GetAllTicketOrdersAsync()
        => await TicketOrderDAO.GetAllTicketOrdersAsync();

    public async Task<TicketOrder?> GetTicketOrderByIdAsync(int id)
        => await TicketOrderDAO.GetTicketOrderByIdAsync(id);

    public async Task SoftDeleteTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await TicketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder == null)
        {
            throw new Exception("TicketOrder Id does not exist.");
        }
        else
        {
            await TicketOrderDAO.SoftDeleteAsync(order);
        }
    }

    public async Task UpdateTicketOrderAsync(TicketOrder order)
    {
        var tmpTicketOrder = await TicketOrderDAO.GetTicketOrderByIdAsync(order.Id);
        if (tmpTicketOrder == null)
        {
            throw new Exception("TicketOrder Id does not exist.");
        }
        else
        {
            await TicketOrderDAO.UpdateAsync(order);
        }
    }
}

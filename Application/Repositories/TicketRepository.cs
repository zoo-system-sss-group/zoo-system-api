using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class TicketRepository : ITicketRepository
{
    public async Task AddTicketAsync(Ticket ticket)
    {
        var tmpTicket = await TicketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket != null)
        {
            throw new Exception("Duplicate ticket Id.");
        } else
        {
            await TicketDAO.SaveAsync(ticket);
        }        
    }        

    public async Task DeleteTicketAsync(Ticket ticket)
    {
        var tmpTicket = await TicketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket == null)
        {
            throw new Exception("Ticket Id does not exist.");
        }
        else
        {
            await TicketDAO.DeleteAsync(ticket);
        }
    }

    public async Task<List<Ticket>> GetAllTicketsAsync()
        => await TicketDAO.GetAllTicketDetailsAsync();    

    public async Task<Ticket?> GetTicketByIdAsync(int id)
        => await TicketDAO.GetByIdAsync(id);    

    public async Task SoftDeleteTicketAsync(Ticket ticket)
    {
        var tmpTicket = await TicketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket == null)
        {
            throw new Exception("Ticket Id does not exist.");
        }
        else
        {
            await TicketDAO.SoftDeleteAsync(ticket);
        }
    }

    public async Task UpdateTicketAsync(Ticket ticket)
    {
        var tmpTicket = await TicketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket == null)
        {
            throw new Exception("Ticket Id does not exist.");
        }
        else
        {
            await TicketDAO.UpdateAsync(ticket);
        }
    }    

    public async Task AddTicketAsync(List<Ticket> tickets)
        => await TicketDAO.SaveRangeAsync(tickets);    
}

﻿using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;

namespace Application.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly TicketDAO _ticketDAO;

    public TicketRepository(TicketDAO ticketDAO)
    {
        _ticketDAO = ticketDAO;
    }

    public async Task AddTicketAsync(Ticket ticket)
    {
        var tmpTicket = await _ticketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket != null)
        {
            throw new Exception("Duplicate ticket Id.");
        } else
        {
            await _ticketDAO.SaveAsync(ticket);
        }        
    }        

    public async Task DeleteTicketAsync(int ticketId)
    {
        var ticket = await _ticketDAO.GetByIdAsync(ticketId);
        if (ticket == null)
        {
            throw new ArgumentException("Ticket Id does not exist.");
        }
        else
        {
            await _ticketDAO.SoftDeleteAsync(ticket);
        }
    }

    public async Task<List<Ticket>> GetAllTicketsAsync()
    {
        return await _ticketDAO.GetAllTicketDetailsAsync();
    }        

    public async Task<Ticket?> GetTicketByIdAsync(int id)
    {
        return await _ticketDAO.GetByIdAsync(id);
    }

    public async Task SoftDeleteTicketAsync(int ticketId)
    {
        var ticket = await _ticketDAO.GetByIdAsync(ticketId);
        if (ticket == null)
        {
            throw new ArgumentException("Ticket Id does not exist.");
        }
        else
        {
            await _ticketDAO.SoftDeleteAsync(ticket);
        }
    }

    public async Task UpdateTicketAsync(Ticket ticket)
    {
        var tmpTicket = await _ticketDAO.GetByIdAsync(ticket.Id);
        if (tmpTicket == null)
        {
            throw new ArgumentException("Ticket Id does not exist.");
        }
        else
        {
            tmpTicket.IsActive = ticket.IsActive;
            await _ticketDAO.UpdateAsync(tmpTicket);
        }
    }    

    public async Task AddTicketAsync(List<Ticket> tickets)
    {
        await _ticketDAO.SaveRangeAsync(tickets);
    }           
}

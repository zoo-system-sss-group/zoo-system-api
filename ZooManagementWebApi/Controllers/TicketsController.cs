using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.IRepositories;
using AutoMapper;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.Authorization;
using ZooManagementWebApi.DTOs;
using DataAccess.Commons;
using Domain.Enums;

namespace ZooManagementWebApi.Controllers;

[EnableQuery]
public class TicketsController : ControllerBase
{
    private readonly ITicketRepository _ticketRepo;
    private readonly IMapper _mapper;
    private readonly AppConfiguration _config;

    public TicketsController(ITicketRepository ticketRepository, IMapper mapper,
                            AppConfiguration config)
    {
        _ticketRepo = ticketRepository;
        _mapper = mapper;
        _config = config;
    }
    // GET: odata/Tickets
    [HttpGet]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<ActionResult<IEnumerable<Ticket>>> Get()
    {
        List<Ticket> Tickets;
        try
        {
            Tickets = await _ticketRepo.GetAllTicketsAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok(Tickets);
    }

    // GET: odata/Tickets/5
    [HttpGet]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<ActionResult<Ticket>> Get([FromRoute] int key)
    {
        var ticket = await _ticketRepo.GetTicketByIdAsync(key);

        if (ticket == null)
        {
            return NotFound();
        }

        return Ok(ticket);
    }

    // PUT: odata/Tickets/5
    [HttpPut]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<IActionResult> Put([FromRoute] int key, [FromBody] TicketUpdateDto dto)
    {
        try
        {
            if (dto == null)
            {
                return BadRequest($"Invalid ticket type!");
            }

            var ticket = _mapper.Map<Ticket>(dto);
            ticket.Id = key;

            // asign the price
            var typeId = (int)dto.TicketType;
            var ticketType = _config.TicketTypeInformation.TicketType
                                .FirstOrDefault(x => x.Id.Equals(typeId.ToString()));

            if (ticketType != null)
            {
                ticket.Price = double.Parse(ticketType.Price);
                await _ticketRepo.UpdateTicketAsync(ticket);
            }
            else
            {
                return BadRequest("Opps! Something wrongs with the ticket type!");
            }            
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return NoContent();
    }    

    // DELETE: odata/Tickets/5
    [HttpDelete]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<IActionResult> Delete([FromRoute] int key)
    {
        try
        {
            await _ticketRepo.DeleteTicketAsync(key);
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return NoContent();
    }

    // GET: api/tickets/types
    [HttpGet("api/tickets/types")]
    public IActionResult GetAllTicketTypes()
    {
        List<TicketType> ticketTypes;
        try
        {
            ticketTypes = _config.TicketTypeInformation.TicketType  // Bị duplicate items :((
                            .DistinctBy(x => x.Id)
                            .ToList(); 
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok(ticketTypes);
    }
}

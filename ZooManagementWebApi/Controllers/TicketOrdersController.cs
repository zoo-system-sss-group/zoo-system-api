using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using ZooManagementWebApi.DTOs;
using Application.IRepositories;
using AutoMapper;

namespace ZooManagementWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketOrdersController : ControllerBase
{
    private readonly ITicketRepository _ticketRepo;
    private readonly ITicketOrderRepository _orderRepo;
    private readonly IMapper _mapper;

    public TicketOrdersController(ITicketRepository ticketRepository,
                                ITicketOrderRepository orderRepo,
                                IMapper mapper)
    {
        _ticketRepo = ticketRepository;
        _mapper = mapper;
        _orderRepo = orderRepo;
    }

    // GET: api/TicketOrders
    [HttpGet]
    public async Task<IActionResult> GetTicketOrders()
    {
        try
        {
            return Ok(new ApiResponse
            {
                Success = true,
                Value = await _orderRepo.GetAllTicketOrdersAsync()
            });
        }
        catch (Exception ex)
        {
            return BadRequest(new ApiResponse
            {
                Success = false,
                ErrorMessage = $"{ex.Message}"
            });
        }
    }

    // GET: api/TicketOrders/5
    [HttpGet("{id}")]
    public async Task<ActionResult> GetTicketOrder(int id)
    {
        var ticketOrder = await _orderRepo.GetTicketOrderByIdAsync(id);
        if (ticketOrder == null)
        {
            return NotFound(new ApiResponse
            {
                Success = false,
                ErrorMessage = "TicketOrder Id does not exist."
            });
        }
        return Ok(new ApiResponse
        {
            Success = true,
            Value = _mapper.Map<TicketOrderViewDTO>(ticketOrder)
        });
    }

    // PUT: api/TicketOrders/5        
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTicketOrder(int id, TicketOrderUpdateDTO dto)
    {
        var tmp = await _orderRepo.GetTicketOrderByIdAsync(id);
        if (tmp == null)
        {
            return NotFound(new ApiResponse
            {
                Success = false,
                ErrorMessage = "TicketOrder Id does not exist."
            });
        }
        try
        {
            var ticketOrder = _mapper.Map<TicketOrder>(dto);
            ticketOrder.Id = id;
            await _orderRepo.UpdateTicketOrderAsync(ticketOrder);
        }
        catch (Exception ex)
        {
            return BadRequest(new ApiResponse
            {
                Success = false,
                ErrorMessage = $"{ex.Message}"
            });
        }

        return NoContent();
    }

    // POST: api/TicketOrders/
    [HttpPost()]
    public async Task<ActionResult<Ticket>> PurchaseTicket(TicketOrderCreateDTO dto)
    {
        // Create ticket order
        var lastestOrder = (await _orderRepo.GetAllTicketOrdersAsync()).OrderBy(x => x.Id).LastOrDefault();
        var order = _mapper.Map<TicketOrder>(dto);
        order.Id = lastestOrder == null ? 1 : lastestOrder.Id + 1;
        try
        {            
            // Create ticket
            var tickets = new List<Ticket>();
            foreach (var item in dto.Tickets)
            {
                var ticketType = await _ticketRepo.GetTicketTypeByCodeAsync(item.TypeCode);
                if (ticketType == null)
                {
                    throw new Exception("Invalid ticket type");
                }
                for (var i = 0; i < item.Quantity; i++)
                {
                    var ticket = new Ticket
                    {
                        TypeCode = item.TypeCode,
                        EffectiveDate = item.EffectiveDate,
                        Price = ticketType.Price,
                        OrderId = order!.Id
                    };
                    tickets.Add(ticket);
                    order.Total += ticket.Price;
                }
            }
            // Save in database
            order.Tickets = tickets;
            await _orderRepo.AddTicketOrderAsync(order);
        }
        catch (Exception ex)
        {
            return BadRequest(new ApiResponse
            {
                Success = false,
                ErrorMessage = $"{ex.Message} Details: {ex}"
            });
        }
        return Ok(new ApiResponse
        {
            Success = true,
            Value = new { id = order.Id }
        });
    }

    // DELETE: api/TicketOrders/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTicketOrder(int id)
    {
        var order = await _orderRepo.GetTicketOrderByIdAsync(id);
        if (order == null)
        {
            return NotFound(new ApiResponse
            {
                Success= false,
                ErrorMessage = "TicketOrder Id does not exist."
            });
        }
        try
        {
            if (order.IsDeleted)
            {
                throw new Exception("This order has been deleted");
            }
            await _orderRepo.SoftDeleteTicketOrderAsync(order);
        }
        catch (Exception ex)
        {
            return BadRequest(new ApiResponse
            {
                Success = false,
                ErrorMessage = $"{ex.Message}"
            });
        }

        return NoContent();
    }
}

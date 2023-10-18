using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.IRepositories;
using ZooManagementWebApi.DTOs;
using AutoMapper;

namespace ZooManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketRepository _ticketRepo;
        private readonly IMapper _mapper;

        public TicketsController(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepo = ticketRepository;
            _mapper = mapper;
        }

        // GET: api/Tickets
        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            try
            {
                return Ok(new ApiResponse
                {
                    Success = true,
                    Value = _mapper.Map<List<TicketDTO>>(await _ticketRepo.GetAllTicketsAsync())
                });
            } catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    ErrorMessage = $"{ex.Message}"
                });
            }
        }

        // GET: api/Tickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetTicket(int id)
        {
            var ticket = await _ticketRepo.GetTicketByIdAsync(id);
            if (ticket == null)
            {
                return NotFound(new ApiResponse
                {
                    Success = false,
                    ErrorMessage = "Ticket Id does not exist."
                });
            }
            return Ok(new ApiResponse
            {
                Success = true,
                Value = _mapper.Map<TicketDTO>(ticket)
            });
        }

        // GET: api/Tickets/types
        [HttpGet("types")]
        public async Task<IActionResult> GetTicketTypes()
        {
            return Ok();
        }

        // PUT: api/Tickets/5        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, TicketUpdateDTO dto)
        {
            var tmp = await _ticketRepo.GetTicketByIdAsync(id);
            if (tmp == null)
            {
                return NotFound(new ApiResponse
                {
                    Success = false,
                    ErrorMessage = "Ticket Id does not exist"
                });
            }
            try
            {
                var ticket = _mapper.Map<Ticket>(dto);
                ticket.Id = id;
                await _ticketRepo.UpdateTicketAsync(ticket);
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

        // DELETE: api/Tickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _ticketRepo.GetTicketByIdAsync(id);
            if (ticket == null)
            {
                return NotFound(new ApiResponse
                {
                    Success = false,
                    ErrorMessage = "Ticket Id does not exist"
                });
            }
            try
            {
                if (ticket.IsDeleted)
                {
                    throw new Exception("This ticket has been deleted");
                }
                await _ticketRepo.SoftDeleteTicketAsync(ticket);
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
}

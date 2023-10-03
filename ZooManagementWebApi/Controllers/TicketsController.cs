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
                    Value = await _ticketRepo.GetAllTicketsAsync()
                });
            } catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    ErrorMessage = $"{ex.Message} . Details:  {ex}"
                });
            }
        }

        // GET: api/Tickets/types
        [HttpGet("types")]
        public async Task<IActionResult> GetTicketTypes()
        {
            try
            {
                return Ok(new ApiResponse
                {
                    Success = true,
                    Value = await _ticketRepo.GetAllTicketTypesAsync()
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    ErrorMessage = $"{ex.Message} . Details:  {ex}"
                });
            }
        }

        // PUT: api/Tickets/5        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, TicketUpdateDTO dto)
        {
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
                    ErrorMessage = $"{ex.Message}. Details: {ex}"
                });
            }

            return NoContent();
        }        

        // DELETE: api/Tickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            try
            {
                var ticket = await _ticketRepo.GetTicketByIdAsync(id);
                if (ticket == null)
                {
                    throw new Exception("Ticket Id does not exist.");
                }
                await _ticketRepo.SoftDeleteTicketAsync(ticket);
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    ErrorMessage = $"{ex.Message} . Details:  {ex}"
                });
            }

            return NoContent();
        }
    }
}

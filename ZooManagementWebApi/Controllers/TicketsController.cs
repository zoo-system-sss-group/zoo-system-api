using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.IRepositories;
using ZooManagementWebApi.DTOs;
using AutoMapper;

namespace ZooManagementWebApi.Controllers;

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

}

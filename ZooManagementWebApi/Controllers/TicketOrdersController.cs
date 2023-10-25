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
}

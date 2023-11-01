using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.IRepositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.OData.Query;
using ZooManagementWebApi.DTOs;
using DataAccess.Commons;
using Domain.Enums;
using System.Globalization;
using Application.IServices;

namespace ZooManagementWebApi.Controllers;

[EnableQuery]
public class TicketOrdersController : ControllerBase
{
    private readonly ITicketOrderRepository _orderRepo;
    private readonly IMapper _mapper;
    private readonly AppConfiguration _config;
    private readonly IEmailService _emailService;

    public TicketOrdersController(ITicketOrderRepository orderRepo,
                                IMapper mapper,
                                AppConfiguration configuration,
                                IEmailService emailService)
    {
        _mapper = mapper;
        _orderRepo = orderRepo;
        _config = configuration;
        _emailService = emailService;
    }

    // GET: odata/TicketOrders
    [HttpGet]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<ActionResult<IEnumerable<TicketOrder>>> Get()
    {
        List<TicketOrder> TicketOrders;
        try
        {
            TicketOrders = await _orderRepo.GetAllTicketOrdersAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok(TicketOrders);
    }

    // GET: odata/TicketOrders/5
    [HttpGet]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<ActionResult<TicketOrder>> Get([FromRoute] int key)
    {
        var ticketOrder = await _orderRepo.GetTicketOrderByIdAsync(key);

        if (ticketOrder == null)
        {
            return NotFound();
        }

        return Ok(ticketOrder);
    }

    // PUT: odata/TicketOrders/5
    [HttpPut]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<IActionResult> Put([FromRoute] int key, [FromBody] TicketOrderDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Invalid payment method or invalid ticket type!");
        }
        try
        {
            var ticketOrder = _mapper.Map<TicketOrder>(dto);
            ticketOrder.Id = key;

            foreach (var t in dto.Tickets)
            {
                for (var i = 0; i < t.Quantity; i++)
                {
                    var typeId = (int)t.TicketType;
                    var ticketType = _config.TicketTypeInformation.TicketType
                                .FirstOrDefault(x => x.Id.Equals(typeId.ToString()));

                    var ticket = new Ticket
                    {
                        TicketType = t.TicketType,
                        Price = double.Parse(ticketType!.Price)
                    };

                    ticketOrder.Tickets.Add(ticket);
                }
            }

            await _orderRepo.UpdateTicketOrderAsync(ticketOrder);

            if (ticketOrder.Status == OrderStatusEnum.Success && !string.IsNullOrEmpty(ticketOrder.Email))
            {
                await SendTicketInfoEmailAsync(ticketOrder);
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

    // POST: odata/TicketOrders
    [HttpPost]
    public async Task<ActionResult<TicketOrder>> Post([FromBody] TicketOrderDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Invalid payment method or invalid ticket type!");
        }
        TicketOrder ticketOrder;
        try
        {
            var lastesItem = (await _orderRepo.GetAllTicketOrdersAsync())
                                .OrderBy(x => x.Id).LastOrDefault();
            var lastesId = 0;
            if (lastesItem != null)
            {
                lastesId = lastesItem.Id;
            }

            ticketOrder = _mapper.Map<TicketOrder>(dto);
            ticketOrder.Id = ++lastesId;

            foreach (var t in dto.Tickets)
            {
                for (var i = 0; i < t.Quantity; i++)
                {
                    var typeId = (int)t.TicketType;
                    var ticketType = _config.TicketTypeInformation.TicketType
                                .FirstOrDefault(x => x.Id.Equals(typeId.ToString()));

                    var ticket = new Ticket
                    {
                        TicketType = t.TicketType,
                        Price = double.Parse(ticketType!.Price),
                        OrderId = ticketOrder.Id
                    };

                    ticketOrder.TotalTicket++;
                    ticketOrder.TotalMoney += ticket.Price;
                    ticketOrder.Tickets.Add(ticket);
                }
            }

            await _orderRepo.AddTicketOrderAsync(ticketOrder);
            // send ticket info to guest email
            if (!string.IsNullOrEmpty(ticketOrder.Email))
                await SendConfirmEmailAsync(ticketOrder);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return CreatedAtAction("Get", new { key = ticketOrder.Id }, ticketOrder);
    }

    // DELETE: odata/TicketOrders/5
    [HttpDelete]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<IActionResult> Delete([FromRoute] int key)
    {
        try
        {
            await _orderRepo.DeleteTicketOrderAsync(key);
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

    // GET: api/ticketorders/payments
    [HttpGet("api/ticketorders/payments")]
    public IActionResult GetAllTicketTypes()
    {
        try
        {
            var payments = new List<PaymentVM>();
            var paymentName = Enum.GetNames(typeof(PaymentEnum)).ToList();
            int i = 0;
            foreach (var s in paymentName)
            {
                payments.Add(new PaymentVM { Id = i++, Name = s });
            }
            return Ok(payments);
        }
        catch (Exception ex)
        {
            return BadRequest(new { ErrorMessage = ex.Message });
        }
    }

    // POST: api/ticketorders/total
    [HttpPost("api/ticketorders/total")]
    public ActionResult GetTotalMoney([FromBody] TicketListDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Invalid payment method or invalid ticket type!");
        }

        try
        {
            double total = 0;

            foreach (var t in dto.Tickets)
            {
                for (var i = 0; i < t.Quantity; i++)
                {
                    var typeId = (int)t.TicketType;
                    var ticketType = _config.TicketTypeInformation.TicketType
                                .FirstOrDefault(x => x.Id.Equals(typeId.ToString()));

                    total += double.Parse(ticketType!.Price);
                }
            }

            return Ok(new { Total = total });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    private async Task SendConfirmEmailAsync(TicketOrder order)
    {
        //file path in localhost
        string exePath = Environment.CurrentDirectory.ToString();
        if (exePath.Contains(@"\bin\Debug\net7.0"))
            exePath = exePath.Remove(exePath.Length - (@"\bin\Debug\net7.0").Length);
        string FilePath = exePath + @"\EmailTemplates\ConfirmEmailTemplate.html";

        StreamReader streamreader = new StreamReader(FilePath);
        string mailText = streamreader.ReadToEnd();
        streamreader.Close();
        var childrenTickets = order.Tickets
                            .Where(x => x.TicketType == TicketTypeEnum.ChildrenTicket)
                            .Count();
        var adultTickets = order.Tickets
                            .Where(x => x.TicketType == TicketTypeEnum.AdultTicket)
                            .Count();
        //Replace email informations
        mailText = mailText.Replace("[CustomerName]", order.CustomerName);
        mailText = mailText.Replace("[CreationDate]", order.CreationDate!.Value.ToString("f"));    
        mailText = mailText.Replace("[Email]", order.Email);
        mailText = mailText.Replace("[PhoneNumber]", order.PhoneNumber);
        mailText = mailText.Replace("[EffectiveDate]", order.EffectiveDate.ToString("f"));
        mailText = mailText.Replace("[ChildrenTickets]", childrenTickets.ToString());
        mailText = mailText.Replace("[AdultTickets]", adultTickets.ToString());
        mailText = mailText.Replace("[TotalMoney]", order.TotalMoney.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")));
        mailText = mailText.Replace("[PaymentMethod]", order.PaymentMethod.ToString());
        // Send email to customer (send reservation information)
        await _emailService.SendMailAsync(new List<string> { order.Email }, "Zoo Management System - Reservation Confirmation", mailText);
    }

    private async Task SendTicketInfoEmailAsync(TicketOrder order)
    {
        //file path in localhost
        string exePath = Environment.CurrentDirectory.ToString();
        if (exePath.Contains(@"\bin\Debug\net7.0"))
            exePath = exePath.Remove(exePath.Length - (@"\bin\Debug\net7.0").Length);
        string FilePath = exePath + @"\EmailTemplates\DefaultTemplate.html";

        StreamReader streamreader = new StreamReader(FilePath);
        string mailText = streamreader.ReadToEnd();
        streamreader.Close();
        var childrenTickets = order.Tickets
                            .Where(x => x.TicketType == TicketTypeEnum.ChildrenTicket)
                            .Count();
        var adultTickets = order.Tickets
                            .Where(x => x.TicketType == TicketTypeEnum.AdultTicket)
                            .Count();
        //Replace email informations
        mailText = mailText.Replace("[CustomerName]", order.CustomerName);
        mailText = mailText.Replace("[CreationDate]", order.CreationDate!.Value.ToString("f"));
        mailText = mailText.Replace("[Email]", order.Email);
        mailText = mailText.Replace("[OrderCode]", order.Code.ToString());
        mailText = mailText.Replace("[PhoneNumber]", order.PhoneNumber);
        mailText = mailText.Replace("[EffectiveDate]", order.EffectiveDate.ToString("f"));
        mailText = mailText.Replace("[ChildrenTickets]", childrenTickets.ToString());
        mailText = mailText.Replace("[AdultTickets]", adultTickets.ToString());
        mailText = mailText.Replace("[TotalMoney]", order.TotalMoney.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")));
        mailText = mailText.Replace("[PaymentMethod]", order.PaymentMethod.ToString());
        // Send email to customer (send reservation information)
        await _emailService.SendMailAsync(new List<string> { order.Email }, "Zoo Management System - Reservation Confirmation", mailText);
    }
}

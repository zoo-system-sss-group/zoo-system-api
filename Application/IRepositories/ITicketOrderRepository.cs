using Domain.Entities;

namespace Application.IRepositories;

public interface ITicketOrderRepository
{
    Task<List<TicketOrder>> GetAllTicketOrdersAsync();
    Task<TicketOrder?> GetTicketOrderByIdAsync(int id);
    Task AddTicketOrderAsync(TicketOrder order);
    Task UpdateTicketOrderAsync(TicketOrder order);
    Task DeleteTicketOrderAsync(int orderId);
    Task SoftDeleteTicketOrderAsync(int orderId);
}

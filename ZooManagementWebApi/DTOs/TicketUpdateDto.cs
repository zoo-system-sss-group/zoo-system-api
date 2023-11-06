using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ZooManagementWebApi.DTOs;

public class TicketUpdateDto
{
    [Required(ErrorMessage = "Is Active field is required!")]
    public bool IsActive { get; set; }
}

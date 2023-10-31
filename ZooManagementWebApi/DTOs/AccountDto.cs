using Domain.Enums;

namespace ZooManagementWebApi.DTOs;

public class AccountDto
{
    public string Username { get; set; } = default!;
    public string Password { get; set; } = default!;
    public RoleEnum Role { get; set; }
    public string? Fullname { get; set; }
    public string? Experiences { get; set; }
    public string? Avatar { get; set; }

}

namespace DataAccess.Commons;

public class AppConfiguration
{
    public ConnectionStrings ConnectionStrings { get; set; } = default!;
    public JwtConfiguration JwtConfiguration { get; set; } = default!;
    public EmailSetting EmailSetting { get; set; } = default!;
    public TicketTypeInformation TicketTypeInformation { get; set; } = default!;
}

#region Classes
public class ConnectionStrings
{
    public string DefaultDB { get; set; } = default!;
}

public class JwtConfiguration
{
    public string SecretKey { get; set; } = default!;
    public string Issuer { get; set; } = default!;
    public string Audience { get; set; } = default!;
}

public class EmailSetting
{
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string DisplayName { get; set; } = default!;
}

public class TicketTypeInformation
{
    public List<TicketType> TicketType { get; set; } = default!;
}
public class TicketType
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Price { get; set; } = default!;
}
#endregion

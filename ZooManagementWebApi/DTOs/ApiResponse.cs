namespace ZooManagementWebApi.DTOs;

public class ApiResponse
{
    public bool Success { get; set; }
    public string? ErrorMessage { get; set; }
    public object? Value { get; set; }
}

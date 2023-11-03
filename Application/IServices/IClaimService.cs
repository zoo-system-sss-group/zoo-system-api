namespace Application.IServices;

public interface IClaimService
{
    public int GetCurrentUserId { get; }
    public string GetCurrentUserName { get; }
    public string GetCurrentRole { get; }
    DateTime? GetCurrentTime { get; }
}

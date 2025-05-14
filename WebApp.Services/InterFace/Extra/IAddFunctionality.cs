namespace WebApp.Services.InterFace.Extra;

public interface IAddFunctionality
{
    public string MakeHash(string value);
    public bool CompareHash(string plainString, string hashString);
    public string GenerateJWTToken(string userName);
    public string GenerateJWTTokenRole(string userRole, string userName, int userId);
    public (string? role, string? userName, string? userId) ValidateToken(string token);
}

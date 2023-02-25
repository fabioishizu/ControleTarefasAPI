namespace ControleProjetosAPI.Data.Dto.Users;

public class LoginUsersDto
{
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? Token { get; set; }
}

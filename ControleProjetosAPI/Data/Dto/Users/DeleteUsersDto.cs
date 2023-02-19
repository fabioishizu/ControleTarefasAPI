using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Users;

public class DeleteUsersDto
{
    public DateTime DeletedAt { get; set; } = DateTime.Now;
}

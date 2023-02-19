using ControleProjetosAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Users;

public class ReadUsersDto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "O UserName precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O UserName é muito longo.")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "A senha precisa ser preenchida.")]
    [MinLength(8, ErrorMessage = "O UserName é muito curto, mínimo de 8 caracteres.")]
    public string Password { get; set; }
    [Required]
    public int CollaboratorsId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}

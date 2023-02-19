using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Collaborator;

public class UpdateCollaboratorDto
{
    [Required(ErrorMessage = "O nome precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O nome é muito longo.")]
    public string Name { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

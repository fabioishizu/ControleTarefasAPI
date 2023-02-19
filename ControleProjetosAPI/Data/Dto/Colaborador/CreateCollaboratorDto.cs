using ControleProjetosAPI.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleProjetosAPI.Data.Dto.Collaborator;

public class CreateCollaboratorDto
{
    [Required(ErrorMessage = "O nome precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O nome é muito longo.")]
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}

using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Collaborator;

public class DeleteCollaboratorDto
{
    public DateTime DeletedAt { get; set; } = DateTime.Now;
}

using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Tasks;

public class DeleteTasksDto
{
    public DateTime DeletedAt { get; set; } = DateTime.Now;
}

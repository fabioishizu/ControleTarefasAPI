using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Tasks;

public class ReadTasksDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int ProjetoId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}

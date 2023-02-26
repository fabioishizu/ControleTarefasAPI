using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Projetos;

public class ReadProjetoDto
{
    public int ProjectId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}

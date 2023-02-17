using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Projetos;

public class ReadProjetoDto
{
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}

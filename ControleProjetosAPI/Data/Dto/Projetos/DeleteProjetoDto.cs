using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Projetos;

public class DeleteProjetoDto
{
    public DateTime DeleteddAt { get; set; } = DateTime.Now;
}

using ControleProjetosAPI.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleProjetosAPI.Data.Dto.Tasks;

public class CreateTasksDto
{
    [Required(ErrorMessage = "O nome do projeto precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O nome do projeto é muito longo.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Preencha uma breve descrição.")]
    public string Description { get; set; }
    public int ProjetoId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}

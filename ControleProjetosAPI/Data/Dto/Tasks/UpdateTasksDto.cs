using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Tasks;

public class UpdateTasksDto
{
    [Required(ErrorMessage = "O nome da task precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O nome da task é muito longo.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Preencha uma breve descrição.")]
    public string Description { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

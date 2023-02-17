using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Projetos;

public class UpdateProjetoDto
{
    [Required(ErrorMessage = "O nome do projeto precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O nome do projeto é muito longo.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Preencha uma breve descrição.")]
    public string Description { get; set; }
    public int ProjetoId { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

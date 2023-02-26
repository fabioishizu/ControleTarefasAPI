using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.Projetos;

public class UpdateProjetoDto
{
    public int? ProjetoId { get; set; }
    [Required(ErrorMessage = "O nome do projeto precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O nome do projeto é muito longo.")]
    public string Name { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime? CreatedAt { get; set; } 
    public DateTime? DeletedAt { get; set; }
}

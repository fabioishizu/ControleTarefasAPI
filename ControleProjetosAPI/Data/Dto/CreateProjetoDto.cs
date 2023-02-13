using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto;

public class CreateProjetoDto
{
    [Required(ErrorMessage = "O nome do projeto precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O nome do projeto é muito longo.")]
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}

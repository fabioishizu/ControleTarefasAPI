using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Model;

public class Collaborators
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O nome precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O nome é muito longo.")]
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

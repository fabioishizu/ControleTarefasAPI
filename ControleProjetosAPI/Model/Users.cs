using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Model;

public class Users
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O UserName precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O UserName é muito longo.")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "A senha precisa ser preenchida.")]
    [MinLength(8, ErrorMessage = "O UserName é muito curto, mínimo de 8 caracteres.")]
    public string Password { get; set; }
    public virtual Collaborators collaborators { get; set; }
    [Required]
    public int CollaboratorsId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

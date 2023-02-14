using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Model;

public class Task
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do projeto precisa ser preenchido.")]
    [MaxLength(100, ErrorMessage = "O nome do projeto é muito longo.")]
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public Task(string name)
    {
        Name = name;
        CreatedAt = DateTime.Now;
        UpdatedAt = null;
        DeletedAt = null;
    }
}

using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Model;

public class TimeTracker
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "A data de início precisa ser preenchida.")]
    public DateTime StartDate { get; set; }
    [Required(ErrorMessage = "A data final precisa ser preenchida.")]
    public DateTime EndDate { get; set; }
    public int TimeZoneId { get; set; }
    public virtual Tasks tasks { get; set; }
    public int TasksId { get; set; }
    public virtual Collaborators collaborators { get; set; }
    public int? CollaboratorsId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

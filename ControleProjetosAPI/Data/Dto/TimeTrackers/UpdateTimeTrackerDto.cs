using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.TimeTracker;

public class UpdateTimeTrackerDto
{
    [Required(ErrorMessage = "A data de início precisa ser preenchida.")]
    public DateTime StartDate { get; set; }
    [Required(ErrorMessage = "A data final precisa ser preenchida.")]
    public DateTime EndDate { get; set; }
    public int TimeZoneId { get; set; }
    public int TasksId { get; set; }
    public int CollaboratorsId { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
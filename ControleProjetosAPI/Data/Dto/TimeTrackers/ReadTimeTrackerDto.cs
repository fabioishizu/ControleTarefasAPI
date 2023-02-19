using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.TimeTracker;

public class ReadTimeTrackerDto
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int TimeZoneId { get; set; }
    public int TasksId { get; set; }
    public int CollaboratorsId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

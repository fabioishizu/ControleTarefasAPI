using System.ComponentModel.DataAnnotations;

namespace ControleProjetosAPI.Data.Dto.TimeTracker;

public class DeleteTimeTrackerDto
{
    public DateTime DeletedAt { get; set; } = DateTime.Now;
}

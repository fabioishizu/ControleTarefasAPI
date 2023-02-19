using ControleProjetosAPI.Data.Dto.TimeTracker;
using ControleProjetosAPI.Model;

namespace ControleProjetosAPI.Profiles;

public class TimeTrackerProfile : AutoMapper.Profile
{
    public TimeTrackerProfile()
    {
        CreateMap<CreateTimeTrackerDto, TimeTracker>();
        CreateMap<UpdateTimeTrackerDto, TimeTracker>();
        CreateMap<TimeTracker, ReadTimeTrackerDto>();
        CreateMap<DeleteTimeTrackerDto, TimeTracker>();
    }
}

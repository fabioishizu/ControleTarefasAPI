using ControleProjetosAPI.Data.Dto.Projetos;
using ControleProjetosAPI.Data.Dto.Tasks;
using ControleProjetosAPI.Model;

namespace ControleProjetosAPI.Profiles;

public class TaskProfile : AutoMapper.Profile
{
	public TaskProfile()
	{
        CreateMap<CreateTasksDto, Tasks>();
        CreateMap<UpdateTasksDto, Tasks>();
        CreateMap<Tasks, ReadTasksDto>();
        CreateMap<DeleteTasksDto, Tasks>();
    }
}

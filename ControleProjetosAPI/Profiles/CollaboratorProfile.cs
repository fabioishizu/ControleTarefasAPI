using ControleProjetosAPI.Data.Dto.Projetos;
using ControleProjetosAPI.Model;
using ControleProjetosAPI.Data.Dto.Collaborator;

namespace ControleProjetosAPI.Profiles;

public class CollaboratorProfile : AutoMapper.Profile
{
	public CollaboratorProfile()
	{
        CreateMap<CreateCollaboratorDto, Collaborators>();
        CreateMap<UpdateCollaboratorDto, Collaborators>();
        CreateMap<Collaborators, ReadCollaboratorDto>();
        CreateMap<DeleteCollaboratorDto, Collaborators>();
    }
}

using ControleProjetosAPI.Data.Dto.Projetos;
using ControleProjetosAPI.Model;

namespace ControleProjetosAPI.Profiles;

public class ProjetosProfile : AutoMapper.Profile
{
	public ProjetosProfile()
	{
		CreateMap<CreateProjetoDto, Projeto>();
        CreateMap<UpdateProjetoDto, Projeto>();
        CreateMap<DeleteProjetoDto, Projeto>();
        CreateMap<Projeto, ReadProjetoDto>();
    }
}

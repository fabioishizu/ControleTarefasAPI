using ControleProjetosAPI.Data.Dto;
using ControleProjetosAPI.Model;

namespace ControleProjetosAPI.Profiles;

public class ProjetosProfile : AutoMapper.Profile
{
	public ProjetosProfile()
	{
		CreateMap<CreateProjetoDto, Projeto>();
        CreateMap<UpdateProjetoDto, Projeto>();
        CreateMap<Projeto, ReadProjetoDto>();
    }
}

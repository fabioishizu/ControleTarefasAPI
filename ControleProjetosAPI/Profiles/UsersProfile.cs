using ControleProjetosAPI.Model;
using ControleProjetosAPI.Data.Dto.Users;

namespace ControleProjetosAPI.Profiles;

public class UsersProfile : AutoMapper.Profile
{
	public UsersProfile()
	{
        CreateMap<CreateUsersDto, Users>();
        CreateMap<UpdateUsersDto, Users>();
        CreateMap<Users, ReadUsersDto>();
        CreateMap<DeleteUsersDto, Users>();
    }
}

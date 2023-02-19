using AutoMapper;
using ControleProjetosAPI.Data;
using ControleProjetosAPI.Data.Dto.Users;
using ControleProjetosAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ControleUserssAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private ProjetoContext _context;
    private IMapper _mapper;

    public UsersController(ProjetoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;  
    }

    [HttpPost]
    public IActionResult AdicionaUsers([FromBody] CreateUsersDto UsersDto)
    {
        try
        {
            Users Users = _mapper.Map<Users>(UsersDto);
            _context.Users.Add(Users);
            _context.SaveChanges();
            return Ok(Users);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet]
    public IEnumerable<ReadUsersDto> GetUserss([FromQuery] int skip=0, [FromQuery] int take = 50)
    {
        try
        {
            return _mapper.Map<List<ReadUsersDto>>(_context.Users.Skip(skip).Take(take));
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetUsersPorId(int id)
    {
        try
        {
            var Users = _context.Users.FirstOrDefault(Users => Users.Id == id);
            if(Users == null) return NotFound();

            var UsersDto = _mapper.Map<ReadUsersDto>(Users);
            return Ok(UsersDto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaUsers(int id)
    {
        var Users = _context.Users.FirstOrDefault(Users => Users.Id == id);
        if (Users == null) return NotFound();

        _context.Users.Remove(Users);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaUsers(int id, [FromBody] UpdateUsersDto UsersDto)
    {
        var Users = _context.Users.FirstOrDefault(Users => Users.Id == id);
        if(Users == null) return NotFound();

        _mapper.Map(UsersDto, Users);
        _context.SaveChanges();
        return NoContent();
    }
}

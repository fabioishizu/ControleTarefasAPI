using AutoMapper;
using ControleProjetosAPI.Data;
using ControleProjetosAPI.Data.Dto.Users;
using ControleProjetosAPI.Model;
using ControleProjetosAPI.Utils.CryptoSharp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;

namespace ControleUserssAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IConfiguration _config;
    private ProjetoContext _context;
    private IMapper _mapper;

    public UsersController(ProjetoContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _config = configuration;
    }

    [HttpPost]
    public async Task<ActionResult> AddUser([FromBody] CreateUsersDto UsersDto)
    {
        try
        {
            Users Users = _mapper.Map<Users>(UsersDto);
            Users.Password = CryptoSharp.Codifica(UsersDto.Password);
            _context.Users.Add(Users);
            _context.SaveChanges();
            return Ok(Users);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpPost("login"), AllowAnonymous]
    public async Task<ActionResult<LoginUsersDto>> Login(LoginUsersDto loginUserDto)
    {
        var userMatch= _mapper.Map<List<ReadUsersDto>>(_context.Users)
            .FirstOrDefault(user => user.UserName == loginUserDto.UserName && CryptoSharp.Compara(loginUserDto.Password,user.Password));

        if (userMatch == null) return BadRequest("User not found. :(");

        string token = CreateToken(loginUserDto);
        loginUserDto.Token = token;

        return Ok(loginUserDto);
    }

    private string CreateToken(LoginUsersDto user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName)
        };

        var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8
            .GetBytes(_config.GetSection("AppSettings:Token").Value));

        var cred = new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: cred
            );

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

    [HttpGet]
    public IEnumerable<ReadUsersDto> GetAllUsers([FromQuery] int skip=0, [FromQuery] int take = 50)
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
    public async Task<ActionResult> GetUserById(int id)
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
    public async Task<ActionResult> DeleteUser(int id)
    {
        var Users = _context.Users.FirstOrDefault(Users => Users.Id == id);
        if (Users == null) return NotFound();

        _context.Users.Remove(Users);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateUser(int id, [FromBody] UpdateUsersDto UsersDto)
    {
        var Users = _context.Users.FirstOrDefault(Users => Users.Id == id);
        if(Users == null) return NotFound();

        _mapper.Map(UsersDto, Users);
        _context.SaveChanges();
        return NoContent();
    }
}

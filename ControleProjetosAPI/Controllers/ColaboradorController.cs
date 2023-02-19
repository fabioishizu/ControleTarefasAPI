using AutoMapper;
using ControleProjetosAPI.Data;
using ControleProjetosAPI.Data.Dto.Projetos;
using ControleProjetosAPI.Data.Dto.Collaborator;
using ControleProjetosAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ControleColaboradorsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ColaboradorController : ControllerBase
{
    private ProjetoContext _context;
    private IMapper _mapper;

    public ColaboradorController(ProjetoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;  
    }

    [HttpPost]
    public IActionResult AdicionaColaborador([FromBody] CreateCollaboratorDto ColaboradorDto)
    {
        try
        {
            Collaborators Colaborador = _mapper.Map<Collaborators>(ColaboradorDto);
            _context.Collaborators.Add(Colaborador);
            _context.SaveChanges();
            return Ok(Colaborador);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet]
    public IEnumerable<ReadCollaboratorDto> GetColaboradors([FromQuery] int skip=0, [FromQuery] int take = 50)
    {
        try
        {
            return _mapper.Map<List<ReadCollaboratorDto>>(_context.Collaborators.Skip(skip).Take(take));
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetColaboradorPorId(int id)
    {
        try
        {
            var Colaborador = _context.Collaborators.FirstOrDefault(Colaborador => Colaborador.Id == id);
            if(Colaborador == null) return NotFound();

            var ColaboradorDto = _mapper.Map<ReadCollaboratorDto>(Colaborador);
            return Ok(ColaboradorDto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaColaborador(int id)
    {
        var Colaborador = _context.Collaborators.FirstOrDefault(Colaborador => Colaborador.Id == id);
        if (Colaborador == null) return NotFound();

        _context.Collaborators.Remove(Colaborador);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaColaborador(int id, [FromBody] UpdateCollaboratorDto ColaboradorDto)
    {
        var Colaborador = _context.Collaborators.FirstOrDefault(Colaborador => Colaborador.Id == id);
        if(Colaborador == null) return NotFound();

        _mapper.Map(ColaboradorDto, Colaborador);
        _context.SaveChanges();
        return NoContent();
    }
}

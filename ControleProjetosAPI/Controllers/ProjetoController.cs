using AutoMapper;
using ControleProjetosAPI.Data;
using ControleProjetosAPI.Data.Dto.Projetos;
using ControleProjetosAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ControleProjetosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjetoController : ControllerBase
{
    private ProjetoContext _context;
    private IMapper _mapper;

    public ProjetoController(ProjetoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;  
    }

    [HttpPost]
    public IActionResult AdicionaProjeto([FromBody] CreateProjetoDto projetoDto)
    {
        try
        {
            Projeto projeto = _mapper.Map<Projeto>(projetoDto);
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
            return Ok(projeto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet]
    public IEnumerable<ReadProjetoDto> GetProjetos([FromQuery] int skip=0, [FromQuery] int take = 50)
    {
        try
        {
            return _mapper.Map<List<ReadProjetoDto>>(_context.Projetos.Skip(skip).Take(take));
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetProjetoPorId(int id)
    {
        try
        {
            var projeto = _context.Projetos.FirstOrDefault(projeto => projeto.ProjectId == id);
            if(projeto == null) return NotFound();

            var projetoDto = _mapper.Map<ReadProjetoDto>(projeto);
            return Ok(projetoDto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaProjeto(int id)
    {
        var projeto = _context.Projetos.FirstOrDefault(projeto => projeto.ProjectId == id);
        if (projeto == null) return NotFound();

        _context.Projetos.Remove(projeto);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaProjeto(int id, [FromBody] UpdateProjetoDto projetoDto)
    {
        var projeto = _context.Projetos.FirstOrDefault(projeto => projeto.ProjectId == id);
        if(projeto == null) return NotFound();

        _mapper.Map(projetoDto, projeto);
        _context.SaveChanges();
        return NoContent();
    }
}

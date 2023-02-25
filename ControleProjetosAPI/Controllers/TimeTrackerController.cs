using AutoMapper;
using ControleProjetosAPI.Data;
using ControleProjetosAPI.Data.Dto.TimeTracker;
using ControleProjetosAPI.Model;
using Microsoft.AspNetCore.Mvc;
using ControleProjetosAPI.Data.Bll.TimeTracker;
using Microsoft.AspNetCore.Authorization;

namespace ControleTimeTrackersAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class TimeTrackerController : ControllerBase
{
    private ProjetoContext _context;
    private IMapper _mapper;

    public TimeTrackerController(ProjetoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;  
    }

    [HttpPost]
    public IActionResult AdicionaTimeTracker([FromBody] CreateTimeTrackerDto TimeTrackerDto)
    {
        try
        {
            TimeTracker TimeTracker = _mapper.Map<TimeTracker>(TimeTrackerDto);
            if (!TimeTrackerBll.validaDateTime(TimeTracker.StartDate, TimeTracker.EndDate)) throw new BadHttpRequestException("Data de início maior que a de fim.");
            _context.TimeTrackers.Add(TimeTracker);
            _context.SaveChanges();
            return Ok(TimeTracker);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet]
    public IEnumerable<ReadTimeTrackerDto> GetTimeTrackers([FromQuery] int skip=0, [FromQuery] int take = 50)
    {
        try
        {
            return _mapper.Map<List<ReadTimeTrackerDto>>(_context.TimeTrackers.Skip(skip).Take(take));
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetTimeTrackerPorId(int id)
    {
        try
        {
            var TimeTracker = _context.TimeTrackers.FirstOrDefault(TimeTracker => TimeTracker.Id == id);
            if(TimeTracker == null) return NotFound();

            var TimeTrackerDto = _mapper.Map<ReadTimeTrackerDto>(TimeTracker);
            return Ok(TimeTrackerDto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaTimeTracker(int id)
    {
        var TimeTracker = _context.TimeTrackers.FirstOrDefault(TimeTracker => TimeTracker.Id == id);
        if (TimeTracker == null) return NotFound();

        _context.TimeTrackers.Remove(TimeTracker);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaTimeTracker(int id, [FromBody] UpdateTimeTrackerDto TimeTrackerDto)
    {
        var TimeTracker = _context.TimeTrackers.FirstOrDefault(TimeTracker => TimeTracker.Id == id);
        if(TimeTracker == null) return NotFound();

        _mapper.Map(TimeTrackerDto, TimeTracker);
        _context.SaveChanges();
        return NoContent();
    }
}

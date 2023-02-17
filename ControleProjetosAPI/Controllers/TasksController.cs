using AutoMapper;
using ControleProjetosAPI.Data;
using ControleProjetosAPI.Model;
using Microsoft.AspNetCore.Mvc;
using ControleProjetosAPI.Data.Dto.Tasks;
using System.Threading.Tasks;

namespace ControleTasksAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private ProjetoContext _context;
    private IMapper _mapper;

    public TasksController(ProjetoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;  
    }

    [HttpPost]
    public IActionResult AdicionaTask([FromBody] CreateTasksDto TaskDto)
    {
        try
        {
            Tasks task = _mapper.Map<Tasks>(TaskDto);
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return Ok(task);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet]
    public IEnumerable<ReadTasksDto> GetTasks([FromQuery] int skip=0, [FromQuery] int take = 50)
    {
        try
        {
            return _mapper.Map<List<ReadTasksDto>>(_context.Tasks.Skip(skip).Take(take));
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetTaskPorId(int id)
    {
        try
        {
            var Task = _context.Tasks.FirstOrDefault(Task => Task.Id == id);
            if(Task == null) return NotFound();

            var TaskDto = _mapper.Map<ReadTasksDto>(Task);
            return Ok(TaskDto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaTask(int id, [FromBody] DeleteTasksDto taskDto)
    {
        var task = _context.Tasks.FirstOrDefault(Task => Task.Id == id);
        if (task == null) return NotFound();

        _mapper.Map(taskDto, task);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult atualizatask(int id, [FromBody] UpdateTasksDto taskdto)
    {
        var task = _context.Tasks.FirstOrDefault(task => task.Id == id);
        if (task == null) return NotFound();

        _mapper.Map(taskdto, task);
        _context.SaveChanges();
        return NoContent();
    }
}

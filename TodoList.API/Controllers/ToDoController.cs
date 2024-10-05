using Microsoft.AspNetCore.Mvc;
using TodoList.API.Data;
using TodoList.Models;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ToDoController : ControllerBase
{
    private readonly DataContext _context;

    public ToDoController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetIncompleteToDoItems()
    {
        var incompleteItems = await _context.ToDoItems
            .Where(item => item.IsCompleted == false)
            .ToListAsync();

        return Ok(incompleteItems);
    }
}

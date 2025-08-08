using Microsoft.AspNetCore.Mvc;
using backend.Data;
using backend.Models;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly TodoContext _context;

    public TodoController(TodoContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetTodos() => Ok(_context.Todos.ToList());

    [HttpPost]
    public IActionResult AddTodo(Todo todo)
    {
        _context.Todos.Add(todo);
        _context.SaveChanges();
        return Ok(todo);
    }
}

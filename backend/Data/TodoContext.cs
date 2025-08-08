using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

    public DbSet<Todo> Todos { get; set; }
}

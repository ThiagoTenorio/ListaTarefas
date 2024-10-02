using ListaTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaTarefas.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    DbSet<Tarefas> Tarefas { get; set; }
}

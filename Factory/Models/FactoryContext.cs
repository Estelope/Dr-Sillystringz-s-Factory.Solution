using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactorytContext : DbContext
  {
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }
    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}
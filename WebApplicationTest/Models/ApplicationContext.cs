using Microsoft.EntityFrameworkCore;

namespace WebApplicationTest.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TaskToDo> Tasks { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

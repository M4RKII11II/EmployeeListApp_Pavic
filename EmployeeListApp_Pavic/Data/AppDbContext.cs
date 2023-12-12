using Microsoft.EntityFrameworkCore;

namespace EmployeeListApp_Pavic.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}

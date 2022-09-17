using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=TARIK-PC;database=CoreBlogApiDb;integrated security=true;");
		}
		public DbSet<Employee> Employees { get; set; }
	}
}

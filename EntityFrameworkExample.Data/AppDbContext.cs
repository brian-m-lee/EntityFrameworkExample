using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<Person> People => Set<Person>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Prefer connection string from environment, fallback to LocalDB for development
			var connectionString = Environment.GetEnvironmentVariable("ConnectionStringForEntityFrameworkExample");

			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}

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

			optionsBuilder.UseSqlServer(connectionString, x => x.MigrationsHistoryTable("__EFMigrationsHistory", "Example"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Set your custom default schema here
			modelBuilder.HasDefaultSchema("Example");

			base.OnModelCreating(modelBuilder);
		}
	}
}

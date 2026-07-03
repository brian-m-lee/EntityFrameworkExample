using EntityFrameworkExample.Settings;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample.Data
{
	public class AppDbContext
		: DbContext
	{
		private readonly IConnectionStringBuilder connectionStringBuilder;

		public AppDbContext(IConnectionStringBuilder connectionStringBuilder, DbContextOptions<AppDbContext> options)
			: base(options)
		{
			this.connectionStringBuilder = connectionStringBuilder;
		}

		public DbSet<Person> People => Set<Person>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString = connectionStringBuilder.Build();

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

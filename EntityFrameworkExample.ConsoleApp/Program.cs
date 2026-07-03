using EntityFrameworkExample.Data;
using EntityFrameworkExample.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var appDbContext = Host.CreateDefaultBuilder(args)
	.ConfigureServices((hostContext, services) =>
	{
		services.AddDbContext<AppDbContext>();

		services.AddSingleton<IConfiguration>(new ConfigurationBuilder()
			.SetBasePath(AppContext.BaseDirectory)
			.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
			.AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true)
			.Build()
		);

		services.AddScoped<IConnectionStringBuilder, ConnectionStringBuilder>();
	})
	.Build()
	.Services
	.GetRequiredService<AppDbContext>();

await appDbContext.Database.MigrateAsync();

if (!await appDbContext.People.AnyAsync())
{
	await appDbContext.People.AddAsync(new Person { FirstName = "Alice" });
	await appDbContext.SaveChangesAsync();
}

var people = await appDbContext.People.ToListAsync();

Console.WriteLine("People in database:");
foreach (var p in people.OrderBy(p => p.Id))
{
	Console.WriteLine($"- ({p.Id}) {p.FirstName}");
}

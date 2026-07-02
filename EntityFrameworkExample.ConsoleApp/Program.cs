using EntityFrameworkExample.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using var db = new AppDbContext();
			db.Database.Migrate();

			// Add sample data
			if (!db.People.Any())
			{
				db.People.Add(new Person { FirstName = "Alice" });
				db.People.Add(new Person { FirstName = "Bob" });
				db.SaveChanges();
			}

			// Query and print
			var people = db.People.OrderBy(p => p.Id).ToList();
			Console.WriteLine("People in database:");
			foreach (var p in people)
			{
				Console.WriteLine($"- ({p.Id}) {p.FirstName}");
			}
		}
	}
}

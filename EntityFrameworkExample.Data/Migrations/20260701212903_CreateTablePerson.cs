using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkExample.Data.Migrations
{
	public partial class CreateTablePerson : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "People",
				schema: "Example",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_People", x => x.Id);
				});
		}
		
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "People");
		}
	}
}

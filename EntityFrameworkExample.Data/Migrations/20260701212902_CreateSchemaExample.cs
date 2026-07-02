using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkExample.Data.Migrations
{
	public partial class CreateSchemaExample : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.EnsureSchema("Example");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropSchema("Example");
		}
	}
}

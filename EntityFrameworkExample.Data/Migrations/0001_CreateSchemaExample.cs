using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkExample.Data.Migrations
{
	[DbContext(typeof(AppDbContext))]
	[Migration("0001_CreateSchemaExample")]
	public class CreateSchemaExample : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql(@"
USE EntityFrameworkExample;
GO

IF SCHEMA_ID('Example') IS NULL 
	EXEC('CREATE SCHEMA [Example]');
GO
");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql(@"
USE EntityFrameworkExample;
GO

DROP SCHEMA IF EXISTS [Example];
GO
");
		}
	}
}

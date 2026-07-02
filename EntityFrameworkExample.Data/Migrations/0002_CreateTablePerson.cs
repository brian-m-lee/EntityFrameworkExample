using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkExample.Data.Migrations
{
	[DbContext(typeof(AppDbContext))]
	[Migration("0002_CreateTablePerson")]
	public class CreateTablePerson : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql(@"
USE EntityFrameworkExample;
GO

IF OBJECT_ID(N'Example.People', N'U') IS NULL
BEGIN
CREATE TABLE [Example].[People]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	CONSTRAINT PK_People PRIMARY KEY ([Id])
)
END;
");
		}
		
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql(@"
USE EntityFrameworkExample;
GO

DROP TABLE IF EXISTS [Example].[People]
GO
");
		}
	}
}

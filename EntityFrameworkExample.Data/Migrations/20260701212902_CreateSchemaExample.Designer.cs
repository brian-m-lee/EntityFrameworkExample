using EntityFrameworkExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace EntityFrameworkExample.Data.Migrations
{
	[DbContext(typeof(AppDbContext))]
	[Migration("20260701212902_CreateSchemaExample")]
	partial class CreateSchemaExample
	{

		protected override void BuildTargetModel(ModelBuilder modelBuilder)
		{
		}
	}
}

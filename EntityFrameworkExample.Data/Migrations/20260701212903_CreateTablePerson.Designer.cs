using EntityFrameworkExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace EntityFrameworkExample.Data.Migrations
{
	[DbContext(typeof(AppDbContext))]
	[Migration("20260701212903_CreateTablePerson")]
	partial class CreateTablePerson
	{
		protected override void BuildTargetModel(ModelBuilder modelBuilder)
		{
			modelBuilder
				.HasAnnotation("ProductVersion", "10.0.9")
				.HasAnnotation("Relational:MaxIdentifierLength", 128);

			SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

			modelBuilder.Entity("EntityFrameworkExample.Person", b =>
			{
				b.Property<int>("Id")
					.ValueGeneratedOnAdd()
					.HasColumnType("int");

				SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

				b.Property<string>("FirstName")
					.IsRequired()
					.HasColumnType("nvarchar(max)");

				b.HasKey("Id");

				b.ToTable("People", "Example");
			});
		}
	}
}

using Microsoft.EntityFrameworkCore;

namespace Domain.Configurations
{
	internal class Person6Configuration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Person6>
	{
		public Person6Configuration() : base()
		{
		}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Person6> builder)
		{
			// Company (1) -> (N) Person

			// Optional Relation
			builder
				.HasOne(person => person.Company)
				//.WithMany(company => company.?)
				.WithMany()
				.IsRequired(required: false)
				.HasForeignKey(person => person.CompanyId)
				//.HasForeignKey(foreignKeyPropertyNames: "CompanyId")
				.OnDelete
					(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
				;
		}
	}
}

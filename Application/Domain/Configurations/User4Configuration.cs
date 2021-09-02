using Microsoft.EntityFrameworkCore;

namespace Domain.Configurations
{
	internal class User4Configuration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.User4>
	{
		public User4Configuration() : base()
		{
		}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User4> builder)
		{
			// User (1) -> (N) Post

			// Required Relation
			builder
				.HasMany(user => user.WrittenPosts)
				.WithOne(post => post.WriterUser)
				.IsRequired(required: true)
				.HasForeignKey(post => post.WriterUserId)
				.OnDelete
				(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
				;

			// Optional Relation
			builder
				.HasMany(user => user.VerifiedPosts)
				.WithOne(post => post.VerifierUser)
				.IsRequired(required: false)
				.HasForeignKey(post => post.VerifierUserId)
				.OnDelete
				(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
				;
		}
	}
}

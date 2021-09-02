using Microsoft.EntityFrameworkCore;

namespace Domain.Configurations
{
	internal class Post4Configuration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Post4>
	{
		public Post4Configuration() : base()
		{
		}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Post4> builder)
		{
			// User (1) -> (N) Post

			// Required Relation
			builder
				.HasOne(post => post.WriterUser)
				.WithMany(user => user.WrittenPosts)
				.IsRequired(required: true)
				.HasForeignKey(post => post.WriterUserId)
				.OnDelete
				(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
				;

			// Optional Relation
			builder
				.HasOne(post => post.VerifierUser)
				.WithMany(user => user.VerifiedPosts)
				.IsRequired(required: false)
				.HasForeignKey(post => post.VerifierUserId)
				.OnDelete
				(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
				;
		}
	}
}

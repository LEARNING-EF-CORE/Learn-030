using Microsoft.EntityFrameworkCore;

namespace Domain.Configurations
{
	internal class Order5Configuration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Order5>
	{
		public Order5Configuration() : base()
		{
		}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Order5> builder)
		{
			// Order (1) -> (N) OrderItem

			builder
				.HasMany(order => order.Items)
				//.WithOne(orderItem => orderItem.?)
				.WithOne()
				.IsRequired(required: true)
				//.HasForeignKey(orderItem => orderItem.?)
				.HasForeignKey(foreignKeyPropertyNames: "OrderId")
				.OnDelete
				(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
				;
		}
	}
}

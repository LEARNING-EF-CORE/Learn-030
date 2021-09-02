using Microsoft.EntityFrameworkCore;

namespace Domain.Configurations
{
	internal class User3Configuration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.User3>
	{
		public User3Configuration() : base()
		{
		}

		//public void Configure
		//	(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User3> builder)
		//{
		//	throw new System.NotImplementedException();
		//}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User3> builder)
		{
			// **************************************************
			builder
				// using Microsoft.EntityFrameworkCore;
				.ToTable(name: "Users3")
				;
			// **************************************************

			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	;
			// **************************************************

			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.HasColumnName(name: "Shenase")
			//	;
			// **************************************************

			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.IsRequired(required: true)
			//	;
			// **************************************************

			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.IsRequired(required: true)
			//	.HasMaxLength(maxLength: 20)
			//	;
			// **************************************************

			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.IsRequired(required: true)
			//	// مطلقا این دستور توصیه نمی‌شود و باید توصیف شود
			//	.HasColumnType(typeName: "char")
			//	.HasMaxLength(maxLength: 20)
			//	;
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			// Char(20)
			// nChar(20)
			//
			// VarChar(20)
			// nVarChar(20)
			//
			// text		(Deprecated)(Absolute)
			// ntext	(Deprecated)(Absolute)
			//
			// VarChar(Max)
			// nVarChar(Max)
			// **************************************************
			// Char(20)
			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.IsUnicode(unicode: false)
			//	.HasMaxLength(maxLength: 20)
			//	.IsFixedLength(fixedLength: true)
			//	;
			// **************************************************

			// **************************************************
			// nChar(20)
			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.IsUnicode(unicode: true)
			//	.HasMaxLength(maxLength: 20)
			//	.IsFixedLength(fixedLength: true)
			//	;
			// **************************************************

			// **************************************************
			// VarChar(20)
			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.IsUnicode(unicode: false)
			//	.HasMaxLength(maxLength: 20)
			//	.IsFixedLength(fixedLength: false)
			//	;
			// **************************************************

			// **************************************************
			// nVarChar(20)
			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.IsUnicode(unicode: true)
			//	.HasMaxLength(maxLength: 20)
			//	.IsFixedLength(fixedLength: true)
			//	;
			// **************************************************

			// **************************************************
			// VarChar(max)
			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.IsUnicode(unicode: false)
			//	.IsFixedLength(fixedLength: false)
			//	;
			// **************************************************

			// **************************************************
			// nVarChar(max)
			// **************************************************
			//builder
			//	.Property(current => current.Username)
			//	.IsUnicode(unicode: true)
			//	.IsFixedLength(fixedLength: false)
			//	;
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.Username)
				.IsUnicode(unicode: false)
				.HasMaxLength(maxLength: 20)
				.IsFixedLength(fixedLength: true)
				;
			// **************************************************

			// **************************************************
			// Learning Index
			// **************************************************
			builder
				.HasIndex(current => current.Username)
				.IsUnique(unique: true)
				.IsClustered(clustered: false)
				;
			// **************************************************

			// **************************************************
			builder
				.HasOne(user => user.Role)
				.WithMany(role => role.Users)
				.HasForeignKey(user => user.RoleId)
				.OnDelete
					(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
				;
			// **************************************************
		}
	}
}

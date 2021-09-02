using Microsoft.EntityFrameworkCore;

namespace Persistence
{
	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
	{
		public DatabaseContext() : base()
		{
			Database.EnsureCreated();
		}

		public Microsoft.EntityFrameworkCore.DbSet<Domain.Role1> Roles1 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Domain.User1> Users1 { get; set; }



		public Microsoft.EntityFrameworkCore.DbSet<Domain.Role2> Roles2 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Domain.User2> Users2 { get; set; }



		public Microsoft.EntityFrameworkCore.DbSet<Domain.Role3> Roles3 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Domain.User3> Users3 { get; set; }



		public Microsoft.EntityFrameworkCore.DbSet<Domain.User4> Users4 { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Domain.Post4> Posts4 { get; set; }

		protected override void OnConfiguring
			(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);

			string connectionString =
				"Password=1234512345;Persist Security Info=True;User ID=SA;Initial Catalog=LEARNING_EF_CORE_3;Data Source=.";

			optionsBuilder
				// using Microsoft.EntityFrameworkCore;
				.UseSqlServer(connectionString: connectionString)
				//.UseLazyLoadingProxies()
				;
			;
		}

		protected override void OnModelCreating
			(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
		{
			// دستور ذیل را حذف می‌کنیم
			//base.OnModelCreating(modelBuilder: modelBuilder);

			// Solution (1)
			//modelBuilder
			//	.Entity<Domain.User3>()
			//	.HasOne<Domain.Role3>(user => user.Role)
			//	.WithMany(role => role.Users)
			//	.HasForeignKey(user => user.RoleId)
			//	;
			// /Solution (1)

			// Solution (2)
			//modelBuilder
			//	.Entity<Domain.User3>()
			//	.HasOne(user => user.Role)
			//	.WithMany(role => role.Users)
			//	.HasForeignKey(user => user.RoleId)
			//	;
			// /Solution (2)

			// Solution (3)
			//modelBuilder
			//	.Entity<Domain.User3>()
			//	.HasOne(user => user.Role)
			//	.WithMany(role => role.Users)
			//	.HasForeignKey(user => user.RoleId)
			//	.OnDelete
			//		(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
			//	;
			// /Solution (3)

			// و یا برعکس

			// Solution (4)
			//modelBuilder
			//	.Entity<Domain.Role3>()
			//	.HasMany(role => role.Users)
			//	.WithOne(user => user.Role)
			//	.HasForeignKey(user => user.RoleId)
			//	.OnDelete
			//		(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
			//	;
			// /Solution (4)

			// Solution (5)
			//modelBuilder.ApplyConfiguration
			//	(configuration: new Domain.Configurations.User3Configuration());
			// Solution (5)

			// Solution (6)
			//new Domain.Configurations.User3Configuration()
			//	.Configure(builder: modelBuilder.Entity<Domain.User3>());
			// /Solution (6)

			// Solution (7)
			modelBuilder.ApplyConfigurationsFromAssembly
				(assembly: typeof(Domain.Configurations.User3Configuration).Assembly);
			// /Solution (7)

			// Solution (8)
			// دستور ذیل در همه شرایط ممکن است کار نکند
			//modelBuilder.ApplyConfigurationsFromAssembly
			//	(assembly: System.Reflection.Assembly.GetExecutingAssembly());
			// /Solution (8)
		}
	}
}

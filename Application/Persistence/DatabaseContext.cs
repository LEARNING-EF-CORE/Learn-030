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

		protected override void OnConfiguring
			(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);

			string connectionString =
				"Password=1234512345;Persist Security Info=True;User ID=SA;Initial Catalog=LEARNING_EF_CORE_3;Data Source=.";

			optionsBuilder
				//.UseLazyLoadingProxies()
				// using Microsoft.EntityFrameworkCore;
				.UseSqlServer(connectionString: connectionString)
				;
		}
	}
}

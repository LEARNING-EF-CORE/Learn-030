namespace Domain
{
	[Microsoft.EntityFrameworkCore.Index(propertyNames: nameof(Username), IsUnique = true)]
	public class User2 : Base.Entity
	{
		public User2() : base()
		{
		}

		// **********
		// **********
		// **********
		public virtual Role2 Role { get; set; }
		// **********

		// **********
		public System.Guid RoleId { get; set; }
		// **********
		// **********
		// **********

		// **********
		public int Age { get; set; }
		// **********

		// **********
		public string Username { get; set; }
		// **********
	}
}

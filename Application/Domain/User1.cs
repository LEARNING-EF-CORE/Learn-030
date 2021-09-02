namespace Domain
{
	[Microsoft.EntityFrameworkCore.Index(propertyNames: nameof(Username), IsUnique = true)]
	//[Microsoft.EntityFrameworkCore.Index
	//	(propertyNames: new[] { nameof(RoleId), nameof(Username) }, IsUnique = true)]
	public class User1 : Base.Entity
	{
		public User1() : base()
		{
		}

		// **********
		// **********
		// **********
		public Role1 Role { get; set; }
		// **********

		// **********
		public System.Guid RoleId { get; set; }
		// **********
		// **********
		// **********

		// **********
		public string Username { get; set; }
		// **********
	}
}

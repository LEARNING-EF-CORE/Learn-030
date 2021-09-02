namespace Domain
{
	public class User3 : Base.Entity
	{
		public User3() : base()
		{
		}

		// **********
		// **********
		// **********
		public virtual Role3 Role { get; set; }
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

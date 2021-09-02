namespace Domain
{
	public class Post4 : Base.Entity
	{
		public Post4() : base()
		{
		}

		//public User4 User { get; set; }
		//public System.Guid UserId { get; set; }

		// **********
		// **********
		// **********
		public User4 WriterUser { get; set; }
		// **********

		// **********
		public System.Guid WriterUserId { get; set; }
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		public User4 VerifierUser { get; set; }
		// **********

		// **********
		public System.Guid? VerifierUserId { get; set; }
		// **********
		// **********
		// **********
	}
}

namespace Domain
{
	public class User4 : Base.Entity
	{
		public User4() : base()
		{
		}

		// **********
		public string Username { get; set; }
		// **********

		//public virtual System.Collections.Generic.IList<Post4> Posts { get; set; }

		// **********
		public virtual System.Collections.Generic.IList<Post4> WrittenPosts { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<Post4> VerifiedPosts { get; set; }
		// **********
	}
}

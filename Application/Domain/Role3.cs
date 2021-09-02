namespace Domain
{
	public class Role3 : Base.Entity
	{
		public Role3() : base()
		{
		}

		// **********
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<User3> Users { get; set; }
		// **********
	}
}

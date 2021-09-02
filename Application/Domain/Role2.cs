namespace Domain
{
	[Microsoft.EntityFrameworkCore.Index(propertyNames: nameof(Name), IsUnique = true)]
	public class Role2 : Base.Entity
	{
		public Role2() : base()
		{
		}

		// **********
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<User2> Users { get; set; }
		// **********
	}
}

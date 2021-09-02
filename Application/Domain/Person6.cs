namespace Domain
{
	public class Person6 : Base.Entity
	{
		public Person6() : base()
		{
		}

		// **********
		// **********
		// **********
		public virtual Company6 Company { get; set; }
		// **********

		// **********
		public System.Guid? CompanyId { get; set; }
		// **********
		// **********
		// **********

		// **********
		public string FullName { get; set; }
		// **********
	}
}

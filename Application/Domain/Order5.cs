namespace Domain
{
	public class Order5 : Base.Entity
	{
		public Order5() : base()
		{
		}

		// **********
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<OrderItem5> Items { get; set; }
		// **********
	}
}

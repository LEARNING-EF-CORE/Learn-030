namespace Domain
{
	//[Microsoft.EntityFrameworkCore.Index(propertyNames: "Name", IsUnique = true)]
	[Microsoft.EntityFrameworkCore.Index(propertyNames: nameof(Name), IsUnique = true)]
	public class Role1 : Base.Entity
	{
		public Role1() : base()
		{
			// یه جاهایی الزامی است
			Users =
				new System.Collections.Generic.List<User1>();
		}

		// **********
		public string Name { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<User1> Users { get; set; }
		// **********
	}
}

// نگاه ذیل را توصیه نمی‌کنم
//namespace Domain
//{
//	[Microsoft.EntityFrameworkCore.Index(propertyNames: nameof(Name), IsUnique = true)]
//	public class Role1 : Base.Entity
//	{
//		public Role1() : base()
//		{
//			Users =
//				new System.Collections.Generic.HashSet<User1>();
//		}

//		// **********
//		public string Name { get; set; }
//		// **********

//		// **********
//		public System.Collections.Generic.ICollection<User1> Users { get; set; }
//		// **********
//	}
//}

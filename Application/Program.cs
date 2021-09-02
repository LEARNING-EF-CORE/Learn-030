using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Application
{
	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			Learn_0100();

			//Learn_0200();

			//Learn_0300();

			//Learn_0400();

			//Learn_0500();
		}

		private static void Learn_0100()
		{
			var roleId = new System.Guid();

			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// **************************************************
				var role =
					new Domain.Role1
					{
						Name = "Role Name",
					};

				roleId = role.Id;
				// **************************************************

				databaseContext.Roles1.Add(role);

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// **************************************************
				var role =
					databaseContext.Roles1
					.Where(current => current.Id == roleId)
					.FirstOrDefault();
				// **************************************************

				// **************************************************
				// روش اول
				// **************************************************
				var user1 =
					new Domain.User1
					{
						Username = "User 1",
					};

				user1.RoleId = role.Id;

				databaseContext.Users1.Add(user1);
				// **************************************************

				// **************************************************
				// روش دوم
				// **************************************************
				var user2 =
					new Domain.User1
					{
						Username = "User 2",
					};

				user2.Role = role;

				databaseContext.Users1.Add(user2);
				// **************************************************

				// **************************************************
				// روش سوم
				// **************************************************
				var user3 =
					new Domain.User1
					{
						Username = "User 3",
					};

				var userState =
					databaseContext.Entry(user3).State;

				var roleState =
					databaseContext.Entry(role).State;

				role.Users.Add(user3);

				userState =
					databaseContext.Entry(user3).State;

				roleState =
					databaseContext.Entry(role).State;
				// **************************************************

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static void Learn_0200()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var role =
					databaseContext.Roles1
					.FirstOrDefault()
					;

				if (role == null)
				{
					System.Console.WriteLine("There is not any role in database!");
				}

				// Logic Error!
				//int userCount =
				//	role.Users.Count;
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var user =
					databaseContext.Users1
					.FirstOrDefault()
					;

				if (user == null)
				{
					System.Console.WriteLine("There is not any user in database!");
				}

				// Runtime Error!
				//string roleName = user.Role.Name;
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
				}
			}
		}

		private static void Learn_0300()
		{
			var roleId = new System.Guid();

			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// **************************************************
				var role =
					new Domain.Role2
					{
						Name = "Role Name",
					};

				roleId = role.Id;
				// **************************************************

				databaseContext.Roles2.Add(role);

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// **************************************************
				var role =
					databaseContext.Roles2
					.Where(current => current.Id == roleId)
					.FirstOrDefault();
				// **************************************************

				// **************************************************
				// روش اول
				// **************************************************
				var user1 =
					new Domain.User2
					{
						Username = "User 1",
					};

				user1.RoleId = role.Id;

				databaseContext.Users2.Add(user1);
				// **************************************************

				// **************************************************
				// روش دوم
				// **************************************************
				var user2 =
					new Domain.User2
					{
						Username = "User 2",
					};

				user2.Role = role;

				databaseContext.Users2.Add(user2);
				// **************************************************

				// **************************************************
				// روش سوم
				// **************************************************
				var user3 =
					new Domain.User2
					{
						Username = "User 3",
					};

				var userState =
					databaseContext.Entry(user3).State;

				var roleState =
					databaseContext.Entry(role).State;

				role.Users.Add(user3);

				userState =
					databaseContext.Entry(user3).State;

				roleState =
					databaseContext.Entry(role).State;
				// **************************************************

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static void Learn_0400()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var role =
					databaseContext.Roles2
					.FirstOrDefault()
					;

				if (role == null)
				{
					System.Console.WriteLine("There is not any role in database!");
				}

				int userCount =
					role.Users.Count;
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var user =
					databaseContext.Users3
					.FirstOrDefault()
					;

				if (user == null)
				{
					System.Console.WriteLine("There is not any user in database!");
				}

				string roleName = user.Role.Name;
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
				}
			}
		}

		private static void Learn_0500()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// Include -> using Microsoft.EntityFrameworkCore;

				var role =
					databaseContext.Roles1
					.Include(current => current.Users)
					.FirstOrDefault()
					;

				if (role == null)
				{
					System.Console.WriteLine("There is not any role in database!");
				}

				int userCount =
					role.Users.Count;
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var user =
					databaseContext.Users1
					.Include(current => current.Role)
					.FirstOrDefault()
					;

				if (user == null)
				{
					System.Console.WriteLine("There is not any user in database!");
				}

				string roleName = user.Role.Name;
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
				}
			}
		}

		private static void Learn_0600()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// Role: 10,000,000 Users -> Just 20 Users -> Age < 10 Years

				// **************************************************
				//var role =
				//	databaseContext.Roles2
				//	.Include(current => current.Users)
				//	.FirstOrDefault()
				//	;

				//// 20
				//var users =
				//	role.Users
				//	.Where(current => current.Age < 10)
				//	.ToList()
				//	;
				// **************************************************

				// **************************************************
				var role =
					databaseContext.Roles2
					.Include(current => current.Users.Where(user => user.Age < 10))
					.FirstOrDefault()
					;

				// 20
				var users =
					role.Users
					.ToList()
					;
				// **************************************************
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
				}
			}
		}
	}
}

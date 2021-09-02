Relationship Philosophy:

	User (Fields):
		Username	, RoleName		, ...

	Users Table:
		Dariush		, User			,...
		Ali			, User			,...
		Mohammad	, Supervisor	,...
		Sara		, User			,...
		Ahmad		, Supervisor	,...

		Supervisor -> Administrator

		CityName: طهران -> تهران

	Role (Fields):
		Id			, Name			,...

	Roles Table:
		1			, User			,...
		2			, Supervisor	,...

	User (Fields):
		Username	, RoleId		,...

	Users Table:
		Dariush		, 1				,...
		Ali			, 1				,...
		Mohammad	, 2				,...
		Sara		, 1				,...
		Ahmad		, 2				,...

		Supervisor -> Administrator -> Just One Place!

	--------------------------------------------------

	Role						User
	One				To			Many

	--------------------------------------------------

	Employee (Table)		Manager (Table)		Company (Table)		Product (Table)

	--------------------------------------------------

									BaseEntity (Id)

	Person (FullName, Age)				BaseExtentedEntity (IsActive)		Log (Table)

Employee (Table)	Manager (Table)		Company (Table)		Product (Table)

	--------------------------------------------------

1) Learning Base Entity:
	Abstract

	Guid
		New

		فلسفه

			پروژه‌ای برای شهرداری‌های استان تهران

2) Learning Relation:
	One To Many

	Database First نگاه

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
											System.Guid RoleId
	----------------------------------------------------------

	Code First نگاه

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
											System.Guid RoleId
	IList<User> Users						Role Role
	----------------------------------------------------------

	ولی

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
	IList<User> Users
	----------------------------------------------------------

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
											System.Guid RoleId
	----------------------------------------------------------

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
											Role Role
	----------------------------------------------------------

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
	IList<User> Users						Role Role
	----------------------------------------------------------

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
											System.Guid RoleId
	IList<User> Users
	----------------------------------------------------------

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
											System.Guid RoleId
											Role Role
	----------------------------------------------------------

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
											System.Guid AlakiId
	IList<User> Googooli					Role Magooli
	----------------------------------------------------------

	Attribute or Fluent API -> رگلاژ

3) Learning Index

	[Microsoft.EntityFrameworkCore.Index
		(propertyNames: new[] { nameof(CountryId), nameof(Name) }, IsUnique = true)]
	public class State : Base.Entity
	{
		public User1() : base()
		{
		}

		public Country Country { get; set; }

		public System.Guid CountryId { get; set; }

		public string Name { get; set; }
	}

------------------------------------------------------------------------------------

Lazy Loading Enabled = false - Not Using Virtual:

	role.Users... -> Error!

Lazy Loading Enabled = false - Not Using Virtual:

	Include

	role.Users... -> OK!

Lazy Loading Enabled = true - Using Virtual:

	role.Users... -> OK!

Lazy Loading Enabled = true - Using Virtual:

	Include

	role.Users... -> OK!

------------------------------------------------------------------------------------

Lazy Loading Enabled = true - Using Virtual:

	از بانک اطلاعاتی، اطلاعات می‌آید

	user.Role...	-> OK!
	role.Users...	-> OK!

	یک شیء ایجاد می‌کنیم

	user.Role...	-> NULL!
	role.Users...	-> NULL!

		1) Constructor -> Collection New
		2) هر وقت نیاز داشتید
			role.Users = new System.Collection.List<User>();

------------------------------------------------------------------------------------

Country	(1 - N)	State	(1 - N)	City
States			Country			State
				Cities

من هنوز این ارتباطات را رگلاژ نکرده‌ام

یعنی به صورت پیش‌فرض

Cascade Delete -> فعال است

------------------------------------------------------------------------------------

Lazy Loading:

(1):

	Install-Package Microsoft.EntityFrameworkCore.Proxies

		Microsoft.EntityFrameworkCore.Proxies

			Castle.Core
			Microsoft.EntityFrameworkCore

(2):

	protected override void OnConfiguring
		(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
	{
		//base.OnConfiguring(optionsBuilder);

		string connectionString = "...";

		optionsBuilder
			.UseSqlServer(connectionString: connectionString)
			.UseLazyLoadingProxies()
			;
		;
	}

(3):

	Note: All navigation properties should have [virtual] keyword!
	Note: All class contains navigation properties should have public or protected constructor!

------------------------------------------------------------------------------------

چه موقع برای رابطه (مثلا) یک به چند از عملیات رگلاژ استفاده می‌کنیم

(1):

زمانی که می‌خواهیم رفتار پیش‌فرض
Cascade
را تغییر دهیم

(2):

زمانی که از نام‌گذاری استانداردی استفاده نکرده باشیم

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
											System.Guid RoleId
	IList<User> Users						Role Role
	----------------------------------------------------------

	Role(s)									User(s)
	----------------------------------------------------------
	System.Guid Id							System.Guid Id
											System.Guid Y
	IList<User> X							Role Z
	----------------------------------------------------------

(3):

زمانی که بیش از یک رابطه یک به چند بین دو مدل داریم

------------------------------------------------------------------------------------

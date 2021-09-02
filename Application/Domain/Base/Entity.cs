namespace Domain.Base
{
	public abstract class Entity : object, IEntity
	{
		public Entity() : base()
		{
			// دستور ذیل غلط می‌باشد
			//Id = new System.Guid();

			Id = System.Guid.NewGuid();
		}

		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; set; }
	}
}

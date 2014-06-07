namespace DrinkShop.DAL.Entities
{
	using System.Collections.Generic;
	using DrinkShop.DAL.Entities.Interface;

	public class Drink : IEntity
	{
		public Drink()
		{
			Comments = new List<Comment>();
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public float Strength { get; set; }

		public float Volume { get; set; }

		public string Description { get; set; }

		public float Price { get; set; }

		public string Brand { get; set; }

		public virtual ICollection<Comment>  Comments { get; set; }
	}
}

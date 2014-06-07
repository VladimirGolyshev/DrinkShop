namespace DrinkShop.DAL.Entities
{
	using System;
	using System.Collections.Generic;
	using DrinkShop.DAL.Entities.Interface;

	public class Order : IEntity
	{
		public Order()
		{
			Drinks = new List<Drink>();
		}

		public int Id { get; set; }

		public DateTime CreateDate { get; set; }

		public virtual ICollection<Drink> Drinks { get; set; }
	}
}

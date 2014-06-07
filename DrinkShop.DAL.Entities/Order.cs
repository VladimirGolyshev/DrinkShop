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

		public bool IsPaid { get; set; }

		public string Address { get; set; }

		public int UserId { get; set; }

		public virtual User User { get; set; }

		public virtual ICollection<Drink> Drinks { get; set; }
	}
}

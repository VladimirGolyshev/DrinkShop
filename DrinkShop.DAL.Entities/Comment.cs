namespace DrinkShop.DAL.Entities
{
	using System;
	using DrinkShop.DAL.Entities.Interface;

	public class Comment : IEntity
	{
		public int Id { get; set; }

		public string Text { get; set; }

		public DateTime Date { get; set; }

		public int UserId { get; set; }

		public virtual User User { get; set; }

		public int DrinkId { get; set; }
	}
}

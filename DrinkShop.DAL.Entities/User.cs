namespace DrinkShop.DAL.Entities
{
	using System.Collections.Generic;
	using DrinkShop.DAL.Entities.Interface;

	public class User : IEntity
	{
		public User()
		{
			Comments = new List<Comment>();
		}

		public int Id { get; set; }

		public string Username { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public virtual ICollection<Comment> Comments { get; set; }
	}
}

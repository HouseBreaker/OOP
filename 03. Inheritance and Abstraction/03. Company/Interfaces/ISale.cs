using System;

namespace _03.Company.Interfaces
{
	public interface ISale
	{
		string Name { get; set; }

		DateTime Date { get; set; }

		decimal Price { get; set; }
	}
}

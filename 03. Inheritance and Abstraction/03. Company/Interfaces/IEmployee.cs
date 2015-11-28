using _03.Company.Enums;

namespace _03.Company.Interfaces
{
	public interface IEmployee : IPerson
	{
		decimal Salary { get; set; }

		Department Department { get; set; }
	}
}
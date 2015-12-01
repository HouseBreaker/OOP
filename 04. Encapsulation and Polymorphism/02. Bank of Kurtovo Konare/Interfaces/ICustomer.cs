using _02.Bank_of_Kurtovo_Konare.Customers;

namespace _02.Bank_of_Kurtovo_Konare.Interfaces
{
	public interface ICustomer
	{
		string Name { get; }

		CustomerType CustomerType { get; }
	}
}
namespace _02.Bank_of_Kurtovo_Konare.Interfaces
{
	public interface IAccount
	{
		ICustomer Customer { get; }

		decimal Balance { get; }

		decimal MonthlyInterestRate { get; }

		decimal CalculateInterest(int periodInMonths);
	}
}
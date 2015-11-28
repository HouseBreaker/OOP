namespace _03.Company.Interfaces
{
	public interface ICustomer : IPerson
	{
		decimal NetPurchaseAmount { get; set; }
	}
}

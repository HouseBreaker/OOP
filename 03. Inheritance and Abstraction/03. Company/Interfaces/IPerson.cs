namespace _03.Company.Interfaces
{
	public interface IPerson
	{
		string FirstName { get; }

		string LastName { get; }

		string Id { get; set; }
	}
}
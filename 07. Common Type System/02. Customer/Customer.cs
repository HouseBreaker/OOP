using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Customer
{
	public class Customer : ICloneable, IComparable<Customer>
	{
		// everything here has a public setter so we can check if it clones correctly
		private const string EmailRegexPattern = @"([a-z0-9.-_]+)@(\w+.\w+\.\w+)";

		private string firstName;
		private string middleName;
		private string lastName;

		private long id;

		private string address;
		private int phone;
		private string email;

		private List<Payment> payments;
		private CustomerType customerType;

		public Customer(string firstName, string middleName, string lastName, long id, string address, int phone, string email,
			List<Payment> payments, CustomerType customerType)
		{
			FirstName = firstName;
			MiddleName = middleName;
			LastName = lastName;
			Id = id;
			Address = address;
			Phone = phone;
			Email = email;
			Payments = payments;
			CustomerType = customerType;
		}

		public string FirstName
		{
			get { return firstName; }
			set { firstName = ValidateString(value, nameof(FirstName)); }
		}

		public string MiddleName
		{
			get { return middleName; }
			set { middleName = ValidateString(value, nameof(MiddleName)); }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = ValidateString(value, nameof(lastName)); }
		}

		public long Id
		{
			get { return id; }
			set
			{
				if (value.ToString().Length != 10)
				{
					throw new ArgumentException("ID must consist of 10 digits." + $" It's {value.ToString().Length} digits");
				}
				id = value;
			}
		}

		public string Address
		{
			get { return address; }
			set { address = ValidateString(value, nameof(Address)); }
		}

		public int Phone
		{
			get { return phone; }
			set { phone = value; }
		}

		public string Email
		{
			get { return email; }
			set
			{
				if (!Regex.IsMatch(value, EmailRegexPattern))
				{
					throw new ArgumentException("Invalid email.");
				}
				email = value;
			}
		}

		public List<Payment> Payments
		{
			get { return payments; }
			set { payments = value; }
		}

		public CustomerType CustomerType
		{
			get { return customerType; }
			set { customerType = value; }
		}

		private static string ValidateString(string name, string paramName)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentNullException(paramName, $"{paramName} cannot be empty");
			}

			return name;
		}

		public override bool Equals(object param)
		{
			Customer customer = param as Customer;

			if (customer == null)
			{
				return false;
			}

			//Compare the reference type member fields
			if (!Equals(FirstName, customer.FirstName) ||
			    !Equals(MiddleName, customer.MiddleName) ||
			    !Equals(LastName, customer.LastName) ||
			    !Equals(Address, customer.Address) ||
			    !Equals(Email, customer.Email) ||
			    !Payments.SequenceEqual(customer.Payments))
			{
				return false;
			}

			// Compare the value type member fields
			if (!Equals(Id, customer.Id) ||
			    !Equals(Phone, customer.Phone) ||
			    !Equals(CustomerType, customer.CustomerType))
			{
				return false;
			}

			return true;
		}

		public static bool operator ==(Customer c1, Customer c2)
		{
			return Equals(c1, c2);
		}

		public static bool operator !=(Customer c1, Customer c2)
		{
			return !(c1 == c2);
		}

		public override int GetHashCode()
		{
			return FirstName.GetHashCode() ^
			       MiddleName.GetHashCode() ^
			       LastName.GetHashCode() ^
			       Id.GetHashCode() ^
			       Address.GetHashCode() ^
			       Phone.GetHashCode() ^
			       Email.GetHashCode() ^
			       Payments.GetHashCode() ^
			       CustomerType.GetHashCode();
		}

		object ICloneable.Clone()
		{
			return Clone();
		}

		public Customer Clone()
		{
			return new Customer(firstName, middleName, LastName, Id, Address, Phone, Email, new List<Payment>(Payments),
				CustomerType);
		}

		public int CompareTo(Customer other)
		{
			var sourceName = $"{FirstName}{MiddleName}{LastName}";
			var otherName = $"{other.FirstName}{other.MiddleName}{other.LastName}";

			int nameComparison = string.Compare(sourceName, otherName, StringComparison.Ordinal);
			int idComparison = Id.CompareTo(other.Id);

			return nameComparison + idComparison;
		}

		public override string ToString()
		{
			const string tab = "   ";
			var sb = new StringBuilder();

			sb.AppendLine($"Name: {FirstName} {MiddleName} {LastName}");
			sb.AppendLine(tab + $"ID: {Id}");
			sb.AppendLine(tab + $"Address: {Address}");
			sb.AppendLine(tab + $"Phone: {Phone}");
			sb.AppendLine(tab + $"Email: {Email}");
			sb.AppendLine(tab + $"Payments: {string.Join(", ", Payments)}");
			sb.Append(tab + $"Customer type: {CustomerType}");

			return sb.ToString();
		}
	}
}
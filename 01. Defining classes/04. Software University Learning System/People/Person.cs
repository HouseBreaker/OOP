using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Software_University_Learning_System.People
{
	public abstract class Person
	{
		protected const int Printpadding = 16;

		private string firstName;
		private string lastName;
		private int age;

		protected Person(string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}

		public string FirstName
		{
			get { return firstName; }
			set { firstName = CheckStr(value, "First name"); }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = CheckStr(value, "Last name"); }
		}

		public int Age
		{
			get { return age; }
			set { age = CheckInt(value, "Age"); }
		}

		protected string CheckStr(string value, string paramName)
		{
			if (string.IsNullOrEmpty(value.Trim()))
				throw new ArgumentNullException(paramName, $"{paramName} cannot be blank.");

			return value;
		}

		protected int CheckInt(int value, string paramName)
		{
			if (value < 0)
				throw new ArgumentOutOfRangeException(paramName, $"{paramName} cannot be negative. Attempted input: {value}");

			return value;
		}

		public override string ToString()
		{
			var objectTypeSimple = GetType().Name;
			objectTypeSimple = Regex.Replace(objectTypeSimple, @"([a-z])([A-Z])", "$1 $2");

			var sb = new StringBuilder();
			sb.AppendLine("Type".PadRight(Printpadding) + objectTypeSimple);
			sb.AppendLine("Name".PadRight(Printpadding) + $"{FirstName} {LastName}");
			sb.AppendLine("Age".PadRight(Printpadding) + $"{Age}");
			return sb.ToString();
		}
	}
}
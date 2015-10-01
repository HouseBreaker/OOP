using System;
using System.Reflection;

namespace _03.Exception_Handling
{
	class Person
	{
		
		private string firstname, lastname;
		private int age;

		private const int minage = 0, maxage = 120;

		public Person(string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}

		public string FirstName
		{
			get { return this.firstname; }
			set
			{
				if (isValidStr("firstname", value))
				{
					this.firstname = value;
				}
			}
		}

		public string LastName
		{
			get { return this.lastname; }
			set
			{
				if (isValidStr("lastname", value))
				{
					this.lastname = value;
				}
			}
		}

		public int Age
		{
			get { return this.age; }
			set
			{
				if (isValidInt(value))
				{
					this.age = value;
				}
			}
		}

		private bool isValidInt(int value)
		{
			if (value < minage || value > maxage)
			{
				throw new IndexOutOfRangeException($"Age cannot be less than {minage} or more than {maxage}. Attempted age: {value}");
			}
			return true;
		}

		private static bool isValidStr(string param, string stringToValidate)
		{
			if (!string.IsNullOrEmpty(stringToValidate))
			{
				return true;
			}
			throw new ArgumentNullException(param, "String cannot be null or empty.");
		}
	}
}

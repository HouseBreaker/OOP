using System;

namespace _01.Persons
{
	internal class Person
	{
		private int age;
		private string email;
		private string name;

		public Person(string name, int age, string email)
		{
			Name = name;
			Age = age;
			Email = email;
		}

		public Person(string name, int age)
			: this(name, age, null)
		{
		}


		public string Name
		{
			get { return name; }

			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Name cannot be blank");
				}
				name = value;
			}
		}

		public int Age
		{
			get { return age; }

			set
			{
				if (value < 1 && value > 100)
				{
					throw new ArgumentException("Age needs to be an integer from 1 to 100");
				}
				age = value;
			}
		}

		public string Email
		{
			get { return email; }
			set
			{
				if (value != null && !value.Contains("@"))
				{
					throw new ArgumentException("Email must be either null or contain an @");
				}
				email = value;
			}
		}

		public override string ToString()
		{
			return $"Name: {name}, Age: {age}, Email: {email ?? "not set"}";
		}
	}
}
using System;

namespace _03.Inheritance_and_Abstraction
{
	public abstract class Human
	{
		private string firstName, lastName;

		protected Human(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public string FirstName
		{
			get
			{
				return this.firstName;
			}
			protected set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("firstName", "Name cannot be empty.");
				}
				this.firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return this.lastName;
			}
			protected set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("lastName", "Name cannot be empty.");
				}
				this.lastName = value;
			}
		}
	}
}

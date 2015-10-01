using System;

class Person
{
	private string name;
	private int age;
	private string email;

	public Person(string name, int age, string email)
	{
		this.Name = name;
		this.Age = age;
		this.Email = email;
	}

	public Person(string name, int age)
		: this(name, age, null)
	{

	}



	public string Name
	{
		get { return this.name; }

		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Name cannot be blank");
			}
			this.name = value;
		}
	}

	public int Age
	{
		get { return this.age; }

		set
		{
			if (value < 1 && value > 100)
			{
				throw new ArgumentException("Age needs to be an integer from 1 to 100");
			}
			this.age = value;
		}
	}

	public string Email
	{
		get { return this.email; }
		set
		{
			if (value != null && !value.Contains("@"))
			{
				throw new ArgumentException("Email must be either null or contain an @");
			}
			this.email = value;
		}
	}

	public override string ToString()
	{
		return $"Name: {this.name}, Age: {this.age}, Email: {this.email ?? "not set"}";
	}
}
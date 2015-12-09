using System;
using System.Configuration;

namespace _04.Student_Class
{
	public delegate void PropertyChangeEventHandler(Student sender, PropertyChangeEventArgs args);

	public class Student
	{
		public event PropertyChangeEventHandler PropertyChange;

		private string name;
		private int age;

		public Student(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		public string Name
		{
			get { return name; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("name", "Name cannot be null or whitespace.");
				}

				this.PropertyChange?.Invoke(this, new PropertyChangeEventArgs("Name", this.Name, value));
				this.name = value;
			}
		}

		public int Age
		{
			get { return age; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("age", "Age cannot be negative.");
				}

				this.PropertyChange?.Invoke(this, new PropertyChangeEventArgs("Age", this.Age.ToString(), value.ToString()));
				this.age = value;
			}
		}
	}
}
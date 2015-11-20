using System;

namespace _03.Inheritance_and_Abstraction.People
{
	public class Student : Human
	{
		private const int FacultyNumberLowerBound = 5;
		private const int FacultyNumberUpperBound = 10;

		private string facultyNumber;

		public Student(string firstName, string lastName, string facultyNumber) 
			: base(firstName, lastName)
		{
			this.FacultyNumber = facultyNumber;
		}

		public string FacultyNumber
		{
			get
			{
				return this.facultyNumber;
			}
			set
			{
				if (value.Length < FacultyNumberLowerBound || value.Length > FacultyNumberUpperBound)
				{
					throw new ArgumentOutOfRangeException("facultyNumber", "Faculty number should be in the range [5...10]");
				}
				this.facultyNumber = value;
			}
		}

		public override string ToString()
		{
			return base.ToString() + $" Faculty number: {FacultyNumber}";
		}
	}
}


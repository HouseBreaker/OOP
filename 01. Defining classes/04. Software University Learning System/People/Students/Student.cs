using System.Text;

namespace _04.Software_University_Learning_System.People.Students
{
	public abstract class Student : Person
	{
		private int studentNumber;
		private double averageGrade;

		protected Student(string firstName, string lastName, int age, int studentNumber, double averageGrade) :
			base(firstName, lastName, age)
		{
			this.StudentNumber = studentNumber;
			this.AverageGrade = averageGrade;
		}

		public int StudentNumber
		{
			get { return studentNumber; }
			set { studentNumber = value; }
		}

		public double AverageGrade
		{
			get { return averageGrade; }
			set { averageGrade = value; }
		}

		public override string ToString()
		{
			var sb = new StringBuilder(base.ToString());
			sb.AppendLine("Student number".PadRight(Printpadding) + $"{studentNumber}");
			sb.AppendLine("Average grade".PadRight(Printpadding) + $"{averageGrade}");
			return sb.ToString();
		}
	}
}
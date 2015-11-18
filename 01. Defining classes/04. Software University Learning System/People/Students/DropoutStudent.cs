using System;
using System.Text;

namespace _04.Software_University_Learning_System.People.Students
{
	internal class DropoutStudent : Student
	{
		private string droupoutReason;

		public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade,
			string droupoutReason) : base(firstName, lastName, age, studentNumber, averageGrade)
		{
			this.droupoutReason = droupoutReason;
		}

		public string DroupoutReason
		{
			get { return droupoutReason; }
			set { droupoutReason = CheckStr(ref value); }
		}

		public void Reapply()
		{
			Console.WriteLine(this.ToString());
		}

		public override string ToString()
		{
			var sb = new StringBuilder(base.ToString());
			sb.Append("Dropout reason".PadRight(Printpadding) + $"{droupoutReason}");
			return sb.ToString();
		}
	}
}
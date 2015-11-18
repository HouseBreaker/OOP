using System.Text;

namespace _04.Software_University_Learning_System.People.Students
{
	public class CurrentStudent : Student
	{
		private string currentCourse;

		public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade,
			string currentCourse)
			: base(firstName, lastName, age, studentNumber, averageGrade)
		{
			this.CurrentCourse = currentCourse;
		}

		public string CurrentCourse
		{
			get { return currentCourse; }
			set
			{
				currentCourse = CheckStr(ref value);
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder(base.ToString());
			sb.AppendLine("Current course".PadRight(Printpadding) + $"{CurrentCourse}");
			return sb.ToString();
		}
	}
}
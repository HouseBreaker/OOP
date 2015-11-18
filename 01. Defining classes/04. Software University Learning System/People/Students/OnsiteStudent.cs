using System.Text;

namespace _04.Software_University_Learning_System.People.Students
{
	public class OnsiteStudent : CurrentStudent
	{
		private int numberOfVisits;

		public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade,
			string currentCourse, int numberOfVisits)
			: base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
		{
			this.numberOfVisits = numberOfVisits;
		}

		public int NumberOfVisits
		{
			get { return numberOfVisits; }
			set { numberOfVisits = CheckInt(ref value); }
		}

		public override string ToString()
		{
			var sb = new StringBuilder(base.ToString());
			sb.Append("Number of visits".PadRight(Printpadding) + $"{numberOfVisits}");
			return sb.ToString();
		}
	}
}
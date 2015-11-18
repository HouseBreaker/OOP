namespace _04.Software_University_Learning_System.People.Students
{
	internal class OnlineStudent : CurrentStudent
	{
		public OnlineStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse) : 
			base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
		{
		}
	}
}
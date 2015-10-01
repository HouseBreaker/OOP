using _02.Animals.Interfaces;

namespace _02.Animals.Species
{
	class Tomcat : Cat
	{
		public Tomcat(string name, int age) 
			: base(name, age, "male")
		{
		}
	}
}

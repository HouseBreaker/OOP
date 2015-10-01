using OOP_Exercises;

class DefiningClassesMain
{
	static void Main()
	{
		Dog dog = new Dog();
		dog.Name = "Sharo";

		Dog sharo = new Dog("Ivan", "German Shepherd");

		dog.Bark();
		sharo.Bark();
	}
}
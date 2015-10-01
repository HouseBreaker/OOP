using AnimalFarm.Classes;

namespace AnimalFarm
{
    using System;

    public class AnimalFarm
    {
        public static void Main()
        {
            Chicken chicken = new Chicken("Mara", 3);
            Console.WriteLine(chicken.Name);
        }
    }
}

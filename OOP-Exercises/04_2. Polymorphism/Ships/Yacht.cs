using System;

namespace _04_2.Polymorphism.Ships
{
	public class Yacht : Ship
    {
        public Yacht(string name, double lengthInMeters, double volume)
			: base(name, lengthInMeters, volume)
        {
        }
    }
}

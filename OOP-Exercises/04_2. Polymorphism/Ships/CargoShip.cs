using System;

namespace _04_2.Polymorphism.Ships
{
	public class CargoShip : Ship
    {

        public CargoShip(string name, double lengthInMeters, double volume)
			: base(name, lengthInMeters, volume)
        {
        }
    }
}

using System;
using _04_2.Polymorphism.Interfaces;

namespace _04_2.Polymorphism.Ships
{
	public class Warship : Battleship
    {
        public Warship(string name, double lengthInMeters, double volume)
			: base(name, lengthInMeters, volume)
        {
        }

		public override string Attack(Ship targetShip)
		{
			this.Destroy(targetShip);

			return "Victory is ours!";
		}
    }
}

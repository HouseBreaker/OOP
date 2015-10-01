using System;

namespace _04_2.Polymorphism.Ships
{
	public class AircraftCarrier : Battleship
	{
		private int fighterCapacity;

		public AircraftCarrier(string name, double lengthInMeters, double volume, int fighterCapacity)
			: base(name, lengthInMeters, volume)
		{
			this.FighterCapacity = fighterCapacity;
		}

		public int FighterCapacity
		{
			get { return this.fighterCapacity; }

			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value", "The fighter capacity of an aircraft carrier cannot be negative.");
				}

				this.fighterCapacity = value;
			}
		}

		public override string Attack(Ship targetShip)
		{
			this.Destroy(targetShip);
			return "We bombed them from the sky!";
		}
	}
}

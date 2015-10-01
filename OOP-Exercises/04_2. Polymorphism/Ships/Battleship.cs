using _04_2.Polymorphism.Interfaces;

namespace _04_2.Polymorphism.Ships
{
	public abstract class Battleship : Ship, IAttack
	{
		protected Battleship(string name, double lengthInMeters, double volume)
			: base(name, lengthInMeters, volume)
		{
		}


		public abstract string Attack(Ship targetShip);

		protected void Destroy(Ship targetShip)
		{
			targetShip.IsDestroyed = true;
		}
	}
}

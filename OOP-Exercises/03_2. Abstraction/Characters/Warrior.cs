namespace _03_2.Abstraction.Characters
{
	public class Warrior : Character
	{
		public Warrior() 
			: base(300, 00, 120)
		{
		}

		public override void Attack(Character target)
		{
			target.Health -= this.Damage;
		}
	}
}

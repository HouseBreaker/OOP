namespace TheSlum
{
	using GameEngine;

	public class GameEngineMain
	{
		static void Main()
		{
			Engine engine = new ExtendedEngine();
			engine.Run();
		}
	}
}
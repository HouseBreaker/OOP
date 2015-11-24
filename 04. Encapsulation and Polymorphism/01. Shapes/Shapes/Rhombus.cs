namespace _01.Shapes.Shapes
{
	public class Rhombus : BasicShape
	{
		public Rhombus(double width, double height) :
			base(width, height)
		{
		}

		public override double CalculateArea()
		{
			return (Width*Height)/2;
		}

		public override double CalculatePerimeter()
		{
			return (Width + Height)*2;
		}
	}
}
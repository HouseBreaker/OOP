using System;
using System.Linq;
using _01.Shapes.Interfaces;
using _01.Shapes.Shapes;

namespace _01.Shapes
{
	internal static class ShapesMain
	{
		private static void Main()
		{
			var shapes = new IShape[]
			{
				new Rectangle(1.5, 2),
				new Rhombus(4, 5),
				new Circle(30),
				new Circle(1),
				new Circle(2),
				new Rhombus(2, 3),
				new Rectangle(1.1, 1),
			};

			shapes = shapes.ToList().OrderByDescending(a => a.GetType().Name).ToArray(); // this is optional


			var longestTypePad = shapes.Max(a => a.GetType().Name).Length + 2;
			var longestShapePad = shapes.Max(a => a.ToString()).Length + 2;

			foreach (var shape in shapes)
			{
				Console.WriteLine("{0} -> {1} Area: {2,-8:F2} Perimeter: {3:F2}",
					shape.GetType().Name.PadRight(longestTypePad),
					shape.ToString().PadRight(longestShapePad),
					shape.CalculateArea(),
					shape.CalculatePerimeter());
			}
		}
	}
}
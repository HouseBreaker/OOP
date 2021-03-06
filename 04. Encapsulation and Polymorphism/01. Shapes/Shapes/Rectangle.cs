﻿namespace _01.Shapes.Shapes
{
	public class Rectangle : BasicShape
	{
		public Rectangle(double width, double height) :
			base(width, height)
		{
		}

		public override double CalculateArea()
		{
			return Width*Height;
		}

		public override double CalculatePerimeter()
		{
			return (Width + Height)*2;
		}
	}
}
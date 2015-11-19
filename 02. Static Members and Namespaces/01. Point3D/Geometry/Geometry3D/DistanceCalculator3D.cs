using System;

namespace _02.Static_Members_and_Namespaces_Homework.Geometry.Geometry3D
{
	public static class DistanceCalculator3D
	{
		public static double Calc(Point3D point1, Point3D point2)
		{
			double deltaX = point2.X - point1.X;
			double deltaY = point2.Y - point1.Y;
			double deltaZ = point2.Z - point1.Z;

			return Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
		}
	}
}
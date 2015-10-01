using System;
using _02.Static_Members_and_Namespaces_Homework.Geometry.Geometry3D;

namespace _02.Static_Members_and_Namespaces_Homework
{
	class PointMain
	{
		private static void Main()
		{
			Point3D pointOne = new Point3D(1, 2, 3);
			Point3D pointTwo = new Point3D(4, 5, 7);

			//Console.WriteLine(DistanceCalculator.Calc(pointOne, pointTwo));
			Point3D start = Point3D.StartingPoint;
			var path = new Path3D
			{
				{ 0, 1, 2 },
				{ 3, 4, 3 },
				{ 7, 9, 9 },
				{ 1, 2, 1 },
				{ 2, 6, 8 },
				{ 9, 5, 7 }
			};



			Console.WriteLine(path);
			Console.WriteLine(path.TotalLength());
		}
	}
}

using System;
using System.Linq;
using _02.Static_Members_and_Namespaces_Homework.Geometry.Geometry3D;
using _02.Static_Members_and_Namespaces_Homework.Geometry.Storage;

namespace _02.Static_Members_and_Namespaces_Homework
{
	internal class PointMain
	{
		private static void Main()
		{
			Point3D pointOne = new Point3D(1, 2, 3);
			Point3D pointTwo = new Point3D(4, 5, 7);

			//Console.WriteLine(DistanceCalculator.Calc(pointOne, pointTwo));
			var path = new Path3D
			{
				Point3D.StartingPoint,
				new Point3D(0, 1, 2),
				new Point3D(3, 4, 3),
				new Point3D(7, 9, 9),
				new Point3D(1, 2, 1),
				new Point3D(2, 6, 8),
				new Point3D(9, 5, 7)
			};

			Console.WriteLine(path + Environment.NewLine);
			Console.WriteLine($"Total length of the {path.Count()} points is {path.TotalLength():F2}");

			GeometryTxtStorage.SavePathToFile(path, @"..\..\pathOutput.txt");
			Console.WriteLine();

			var loadedPath = GeometryTxtStorage.LoadPathFromFile(@"..\..\pathToLoad.txt");

			Console.WriteLine("Loaded path from file:");
			Console.WriteLine(loadedPath);
			
		}
	}
}
namespace _02.Static_Members_and_Namespaces_Homework.Geometry.Geometry3D
{
	public class Point3D
	{
		private double x, y, z;

		private static readonly Point3D startingpoint = new Point3D(0, 0, 0);

		public double X { get { return x; } set { x = value; } }
		public double Y { get { return y; } set { y = value; } }
		public double Z { get { return z; } set { z = value; } }

		public Point3D(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public static Point3D StartingPoint
		{
			get { return Startingpoint;}
		}

		public static Point3D Startingpoint
		{
			get
			{
				return startingpoint;
			}
		}

		public override string ToString()
		{
			return $"X: {X}|Y: {Y}|Z: {Z}";
		}
	}
}

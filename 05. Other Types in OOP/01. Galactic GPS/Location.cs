using System;

namespace _01.Galactic_GPS
{
	public struct Location
	{
		private const int LatitudeLimit = 90;
		private const int LongitudeLimit = 180;

		private double latitude;
		private double longitude;
		private Planet planet;

		public Location(double latitude, double longitude, Planet planet) : this()
		{
			this.Latitude = latitude;
			this.Longitude = longitude;
			this.Planet = planet;
		}

		public double Latitude
		{
			get { return latitude; }
			set
			{
				if (value < -LatitudeLimit || value > LatitudeLimit)
				{
					throw new ArgumentOutOfRangeException(nameof(latitude), "Latitude needs to be in range [-90..90]");
				}

				latitude = value;
			}
		}

		public double Longitude
		{
			get { return longitude; }
			set
			{
				if (value < -LongitudeLimit || value > LongitudeLimit)
				{
					throw new ArgumentOutOfRangeException(nameof(longitude), "Longitude needs to be in range [-180..180]");
				}
				
				longitude = value;
			}
		}

		public Planet Planet
		{
			get { return planet; }
			set { planet = value; }
		}

		public override string ToString()
		{
			return $"{Latitude}, {Longitude} - {Planet}";
		}
	}
}
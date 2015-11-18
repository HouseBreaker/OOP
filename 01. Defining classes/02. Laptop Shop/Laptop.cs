using System;
using System.Globalization;
using System.Text;

namespace _2.Laptop_Shop
{
	internal class Laptop
	{
		private double batteryLife;
		private string manufacturer, model, cpu, videoCard, screen;
		private int hardDiskCapacity;
		private decimal price;

		private int memory;

		public Laptop
			(string manufacturer, string model, string cpu, string videoCard, int hardDiskCapacity, string screen, int memory,
				Battery battery,
				double batteryLife, decimal price)
		{
			this.Manufacturer = manufacturer;
			this.Model = model;
			this.CPU = cpu;
			this.VideoCard = videoCard;
			this.HardDiskCapacity = hardDiskCapacity;
			this.Screen = screen;
			this.Memory = memory;
			this.Battery = battery;
			this.BatteryLife = batteryLife;
			this.Price = price;
		}

		public Laptop(string manufacturer, string model)
		{
			Model = model;
			Manufacturer = manufacturer;
		}

		public string Model
		{
			get { return model; }

			set
			{
				CheckValidityStr(value);
				model = value;
			}
		}

		public string Manufacturer
		{
			get { return manufacturer; }

			set
			{
				CheckValidityStr(value);
				manufacturer = value;
			}
		}

		public string CPU
		{
			get { return cpu; }

			set
			{
				CheckValidityStr(value);
				cpu = value;
			}
		}

		public int Memory
		{
			get { return memory; }

			set
			{
				CheckValidityInt(value);
				memory = value;
			}
		}

		public string VideoCard
		{
			get { return videoCard; }

			set
			{
				CheckValidityStr(value);
				videoCard = value;
			}
		}

		public int HardDiskCapacity
		{
			get { return hardDiskCapacity; }

			set
			{
				CheckValidityInt(value);
				hardDiskCapacity = value;
			}
		}

		public string Screen
		{
			get { return screen; }

			set
			{
				CheckValidityStr(value);
				screen = value;
			}
		}

		public Battery Battery { get; set; }

		public double BatteryLife
		{
			get { return batteryLife; }

			set
			{
				CheckValidityInt((int) value);
				batteryLife = value;
			}
		}

		public decimal Price
		{
			get { return price; }

			set
			{
				CheckValidityInt((int) value);
				price = value;
			}
		}


		//Validation methods
		private static void CheckValidityStr(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException(nameof(value) + "cannot be empty");
			}
		}

		private static void CheckValidityInt(int input)
		{
			if (input <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(input), "cannot be negative");
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder();

			const int padding = 15;

			sb.Append("Manufacturer".PadRight(padding) + Manufacturer);
			sb.Append(Environment.NewLine);

			sb.Append("Model".PadRight(padding) + Model);
			sb.Append(Environment.NewLine);


			if (CPU == null)
			{
				return sb.ToString(); // we don't need to print stuff because we're using the simplified constructor
			}

			sb.AppendLine("CPU".PadRight(padding) + CPU);

			sb.Append("RAM".PadRight(padding));
			sb.AppendLine(memory < 1000 ? $"{Memory}MB" : $"{(double) Memory/1000}GB");

			sb.AppendLine("GPU".PadRight(padding) + VideoCard);
			sb.Append("HDD".PadRight(padding));

			sb.AppendLine(hardDiskCapacity < 1000 ? $"{HardDiskCapacity}GB" : $"{(double) HardDiskCapacity/1000}TB");

			sb.AppendLine("Screen".PadRight(padding) + Screen);
			sb.AppendLine("Battery".PadRight(padding) + Battery);
			sb.AppendLine("Battery Life".PadRight(padding) + BatteryLife + "hrs");

			sb.Append($"Price:".PadRight(padding) + $"{Price:C}");
			return sb.ToString();
		}
	}
}
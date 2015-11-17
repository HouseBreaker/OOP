using System;
using System.Text;
using _2.Laptop_Shop;

internal class Laptop
{
	private Battery battery;
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

	public Battery Battery
	{
		get { return battery; }
		set { this.battery = value; }
	}

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

		sb.Append("Manufacturer:".PadRight(padding) + Manufacturer);
		sb.Append(Environment.NewLine);

		sb.Append("Model:".PadRight(padding) + Model);
		sb.Append(Environment.NewLine);


		if (CPU == null)
		{
			return sb.ToString(); // we don't need to print stuff because we're using the simplified constructor
		}

		sb.Append("CPU:".PadRight(padding) + CPU);
		sb.Append(Environment.NewLine);

		sb.Append("RAM:".PadRight(padding));

		if (memory < 1000)
		{
			sb.Append(Memory);
			sb.Append("MB");
		}
		else
		{
			sb.Append((double) Memory/1000);
			sb.Append("GB");
		}

		sb.Append(Environment.NewLine);

		sb.Append("GPU:".PadRight(padding) + VideoCard);
		sb.Append(Environment.NewLine);

		sb.Append("HDD".PadRight(padding));

		if (hardDiskCapacity < 1000)
		{
			sb.Append(HardDiskCapacity);
			sb.Append("GB");
		}
		else
		{
			sb.Append((double) HardDiskCapacity/1000);
			sb.Append("TB");
		}

		sb.Append(Environment.NewLine);

		sb.Append("Screen:".PadRight(padding) + Screen);
		sb.Append(Environment.NewLine);

		sb.Append($"Battery:".PadRight(padding) + Battery);
		sb.Append(Environment.NewLine);

		sb.Append($"Battery Life:".PadRight(padding) + BatteryLife +  "hrs");
		sb.Append(Environment.NewLine);

		sb.Append($"Price:".PadRight(padding) + Price + "BGN");
		return sb.ToString();
	}
}
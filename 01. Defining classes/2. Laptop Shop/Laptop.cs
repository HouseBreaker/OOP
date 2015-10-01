using System;
using System.Text;
using _2.Laptop_Shop;

class Laptop
{
	//model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
	private string model, manufacturer, cpu, gpu, hdd, screen;

	private int ram;
	private Battery battery;
	private double batteryLife;
	private decimal price;

	public Laptop
		(string model,
		string manufacturer,
		string cpu,
		string gpu,
		string hdd,
		string screen,
		int ram,
		Battery battery,
		double batterylife,
		decimal price)
	{
		this.Model = model;
		this.Manufacturer = manufacturer;
		this.CPU = cpu;
		this.GPU = gpu;
		this.HDD = hdd;
		this.Screen = screen;
		this.RAM = ram;
		this.Battery = battery;
		this.BatteryLife = batteryLife;
		this.Price = price;
	}

	public Laptop(string model, string manufacturer)
	{
		this.Model = model;
		this.Manufacturer = manufacturer;
	}

	public string Model
	{
		get { return this.model; }

		set
		{
			CheckValidityStr(value);
			this.model = value;
		}
	}

	public string Manufacturer
	{
		get { return this.manufacturer; }

		set
		{
			CheckValidityStr(value);
			this.manufacturer = value;
		}
	}

	public string CPU
	{
		get { return this.cpu; }

		set
		{
			CheckValidityStr(value);
			this.cpu = value;
		}
	}

	public int RAM
	{
		get { return this.ram; }

		set
		{
			CheckValidityInt(value);
			this.ram = value;
		}
	}

	public string GPU
	{
		get { return this.gpu; }

		set
		{
			CheckValidityStr(value);
			this.gpu = value;
		}
	}

	public string HDD
	{
		get { return this.hdd; }

		set
		{
			CheckValidityStr(value);
			this.hdd = value;
		}
	}

	public string Screen
	{
		get { return this.screen; }

		set
		{
			CheckValidityStr(value);
			this.screen = value;
		}
	}

	public Battery Battery { get; set; }

	public double BatteryLife
	{
		get { return this.batteryLife; }

		set
		{
			CheckValidityInt((int)value);
			this.batteryLife = value;
		}
	}

	public decimal Price
	{
		get { return this.price; }

		set
		{
			CheckValidityInt((int)value);
			this.price = value;
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
		StringBuilder sb = new StringBuilder();
		sb.AppendFormat($"Model - {Model}");
		sb.Append(Environment.NewLine);

		sb.AppendFormat($"Manufacturer - {Manufacturer}");
		if (CPU == null)
		{
			return sb.ToString();
		}
		sb.Append(Environment.NewLine);

		sb.AppendFormat($"CPU - {CPU}");
		sb.Append(Environment.NewLine);

		sb.AppendFormat($"RAM - {RAM}");
		sb.Append(Environment.NewLine);

		sb.AppendFormat($"GPU - {GPU}");
		sb.Append(Environment.NewLine);

		sb.AppendFormat($"HDD - {HDD}");
		sb.Append(Environment.NewLine);

		sb.AppendFormat($"Screen - {Screen}");
		sb.Append(Environment.NewLine);

		sb.AppendFormat($"Battery - {Battery}");
		sb.Append(Environment.NewLine);

		sb.AppendFormat($"Battery Life - {BatteryLife}");
		sb.Append(Environment.NewLine);

		sb.AppendFormat($"Price - {Price}");
		return base.ToString();
	}
}
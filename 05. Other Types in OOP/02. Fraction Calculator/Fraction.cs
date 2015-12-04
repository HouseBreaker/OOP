using System;
using System.Globalization;

namespace _02.Fraction_Calculator
{
	public struct Fraction
	{
		private long numerator;
		private long denominator;

		public Fraction(long numerator, long denominator) : this()
		{
			this.Numerator = numerator;
			this.Denominator = denominator;
		}

		public long Numerator
		{
			get { return numerator; }
			set { numerator = value; }
		}

		public long Denominator
		{
			get { return denominator; }
			set
			{
				if (value == 0)
				{
					throw new ArgumentOutOfRangeException(nameof(Denominator), "The denominator cannot be 0.");
				}
				denominator = value;
			}
		}

		public static Fraction operator +(Fraction f1, Fraction f2)
		{
			var largestCommonDenominator = f1.Denominator*f2.Denominator;

			var numerator1 = f1.Numerator*f2.Denominator;
			var numerator2 = f2.Numerator*f1.Denominator;

			return new Fraction(numerator1 + numerator2, largestCommonDenominator);
		}

		public override string ToString()
		{
			return ((decimal)Numerator/Denominator).ToString(CultureInfo.InvariantCulture);
		}
	}
}
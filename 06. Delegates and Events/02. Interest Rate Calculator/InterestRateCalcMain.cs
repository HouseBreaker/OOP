using System;

namespace _02.Interest_Rate_Calculator
{
	public delegate void Delegate(decimal money, double interest, int years);

	class InterestRateCalcMain
	{
		static void Main()
		{
			var compound = new InterestRateCalculator(500, 5.6, 10, GetCompoundInterest);
			Console.WriteLine(compound);

			var simple = new InterestRateCalculator(2500, 7.2, 15, GetSimpleInterest);
			Console.WriteLine(simple);
		}

		static decimal GetSimpleInterest(decimal sum, double interest, int years)
		{
			return (sum*(decimal) (1 + (interest/100)*years));
		}

		static decimal GetCompoundInterest(decimal sum, double interest, int years)
		{
			const int N = 12;
			return (sum*(decimal) Math.Pow((1 + (interest/100)/N), N*years));
		}
	}
}
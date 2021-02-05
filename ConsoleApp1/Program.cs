using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				CalculateSpecificPercentage();

			}
		}
		static double CalculateSpecificPercentage()
		{
			Console.WriteLine("Crafting Level?");
			double level = Convert.ToDouble(Console.ReadLine());

			double opalFormula = ((level - 1) * 122 / 98 + 129) / 256;
			double jadeFormula = ((level - 1) * 145 / 98 + 101) / 256;
			double topazFormula = ((level - 1) * 150 / 98 + 91) / 256;
			double currentFormula = 0;
			string currentGem = "";
			Console.WriteLine("Opal, Jade, or Red Topaz? (Enter O, J, or R) ");
			string gem = Console.ReadLine().Trim().ToLower();
			

			if(gem == "o")
			{
				currentFormula = opalFormula;
				currentGem = "Opal";
			}else if(gem == "j"){
				currentFormula = jadeFormula;
				currentGem = "Jade";
			}
			else if(gem == "r") {
				currentFormula = topazFormula;
				currentGem = "Red Topaz";
			}
			
			Console.WriteLine($"{opalFormula} chance to successfully cut {currentGem}\n");
			Console.ReadLine();
			return opalFormula;
		}
		static void calculateTotalPercentage()
		{
			double level = 99;
			List<double> opalList = new List<double>();
			double previousFormula = 0;
			int counter = 0;
			while(level >= 1)
			{
				double opalFormula = ((level - 1) * 122 / 98 + 129) / 256;
				
				level--;
				if (counter != 0)
				{
					opalList.Add(previousFormula - opalFormula);
					previousFormula = opalFormula;
				}
				counter++;
			}
			Console.WriteLine(opalList.Average());
			Console.ReadLine();

		}
	}
}

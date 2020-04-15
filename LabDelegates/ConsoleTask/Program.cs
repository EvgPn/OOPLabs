using System;

namespace LabDelegates
{
	class Program
	{
		private static int funcNum;
		private static int xValue;
		private static Func<int, double>[] funcs;

		static void Main(string[] args)
		{
			while (true)
			{
				try
				{
					GetFuncAndXValueInput();
					GetDelegatesLambdaArray();
					ShowCalculationResult();
				}
				catch
				{
					Console.WriteLine("Input string was not in a correct format. Press any key to exit...");
					Console.ReadKey();
					break;
				}
			}
		}

		private static void GetFuncAndXValueInput()
		{
			string[] funcAndX = Console.ReadLine().Split(' ');
			funcNum = int.Parse(funcAndX[0]);
			xValue = int.Parse(funcAndX[1]);
		}

		private static void GetDelegatesLambdaArray()
		{
			Func<int, double>[] functions = new Func<int, double>[3];
			functions[0] = x => Math.Sqrt(Math.Abs(x));
			functions[1] = x => Math.Pow(x, 3);
			functions[2] = x => x + 3.5;
			funcs = functions;
		}

		private static void ShowCalculationResult()
		{
			Console.WriteLine(funcs[funcNum](xValue));
		}
	}
}

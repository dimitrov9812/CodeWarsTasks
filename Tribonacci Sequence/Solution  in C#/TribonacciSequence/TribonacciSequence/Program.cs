using System.Linq;
using System;
public class Xbonacci
{
	public double[] Tribonacci(double[] signature, int n)
	{
		double[] startingArr;
		if (n == 0)
		{
			startingArr = new double[0];
		}
		else if (n == 1)
		{
			startingArr = new double[1];
			startingArr[0] = signature[0];
		}
		else if (n >= 3)
		{
			startingArr = new double[n];
			for (int i = 0; i < signature.Length; i++)
			{
				double temporary = signature[i];
				Console.WriteLine("Temp: " + temporary);
				startingArr[i] = temporary;
				Console.WriteLine(startingArr[i]);
			}
			Console.WriteLine("-1:" + startingArr[0]);
			Console.WriteLine("-1:" + startingArr[startingArr.Length - 2]);
			Console.WriteLine("-1:" + startingArr[startingArr.Length - 3]);

			for (int i = 3; i < startingArr.Length; i++)
			{
				double numberToAdd = startingArr[i - 1] + startingArr[i - 2] + startingArr[i - 3];
				Console.WriteLine(numberToAdd);
				startingArr[i] = numberToAdd;
			}

		}
		else
		{
			startingArr = new double[2];
			startingArr[0] = signature[0];
			startingArr[1] = signature[1];
		}
		return startingArr;
	}
	public static void Main(string[] args)
	{
		double[] arr = new double[] { 2, 19, 13 };
		Xbonacci xbonacci = new Xbonacci();
		double[] print = xbonacci.Tribonacci(arr, 2);
		Console.WriteLine(string.Join(" ", print));
	}

}

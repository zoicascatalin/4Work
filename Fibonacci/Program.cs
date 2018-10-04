using System;

namespace Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = first4Digit();
			Console.WriteLine("First 4 digit in Fibonacci is: " + x);
			Console.ReadLine();
		}
		static int first4Digit()
		{
			int temp = 0;
			int count = 1;
			int a = 1;
			int b = 1;
			while (true)
			{
				temp = b;
				b += a;
				a = temp;
				count++;
				if (b > 999)
				{
					return count;
				}
			}
		}
	}
}

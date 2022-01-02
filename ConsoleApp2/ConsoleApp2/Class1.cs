using System;

namespace ConsoleApp2
{
    class Class1
    {
		static void Main(string[] args)
		{
			int a, b, c;
			Console.WriteLine("Enter the First Number: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the Second Number: ");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the Third Number: ");
			c = Convert.ToInt32(Console.ReadLine());
			int res = Largest(a, b, c);
            Console.WriteLine($"The Largest number is {res}");
		}
		static int Largest(int a, int b, int c)
		{
			int result;
			//int result = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
			if (a > b) 
			{
				if (a > c)
				{
					result = a;
				}
				else 
				{
					result = c;
				}
			}
			else 
			{
				if (b > c)
				{
					result = b;
				}
				else
				{
					result = c;
				}
			}
			return result;
		}
	}
}

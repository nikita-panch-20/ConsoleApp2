using System;


enum DOWEnum { SUN, SAT };
class EnumDemo
{
	public static void Main()
	{
		//Discount

		double amount = GetDiscountValue(DOWEnum.SUN);
		Console.WriteLine("Amount is : " + amount);
	}

	private static double GetDiscountValue(DOWEnum dow)
	{
		double amount = 0;
		//webservice call. After the web call the amount is 180
		amount = 180; //get from web service
		switch (dow)
		{
			case DOWEnum.SUN: amount = amount + (amount * 0.8); break;
			case DOWEnum.SAT: amount = amount + (amount * 0.7); break;
		}
		return amount;
	}
}
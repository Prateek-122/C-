using System;
class leap
{
	public static void Main(string []args)
	{
		int a;
		System.Console.WriteLine("enter the number");
		a=Convert.ToInt32(Console.ReadLine());
		if (a%4==0)
		 if (a%100==0)
		 if (a%400==0)
			 System.Console.WriteLine("leap year");
		 else 
			System.Console.WriteLine("Not leap year");
		else 
			System.Console.WriteLine("Not leap year");
		else 
			System.Console.WriteLine("Not leap year");
	}
}
using System;
class hi
{
	static void Main(string []args)
	{
		int a;
		System.Console.WriteLine("enter the number");
		a=Convert.ToInt32(Console.ReadLine());
		if (a%2==0)
		System.Console.WriteLine("even");
		else 
			System.Console.WriteLine("odd");
		if (a>0)
			System.Console.WriteLine("positive");
		else if (a<0)
			System.Console.WriteLine("negative");
		else 
			System.Console.WriteLine("zero");
			
		
	}
}
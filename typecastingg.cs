using System;
class typecastingg
{
	static void Main(string []args)
	{
		char a;
		System.Console.WriteLine("enter the number");
		a=Convert.ToChar(Console.ReadLine());
		int b=(int)a;
		System.Console.WriteLine(b);
		
	}
}
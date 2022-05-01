using System;
class simpleint
{
	public static void Main(string []args)
	{
		int si=0,p=0,r=0,t=0;
		Console.WriteLine("enter the principal");
		p=int.Parse(Console.ReadLine());
		Console.WriteLine("enter the rate");
		r=int.Parse(Console.ReadLine());
		Console.WriteLine("enter the time in year");
		t=int.Parse(Console.ReadLine());
	   si=p*r*t/100;
	   Console.WriteLine(si+p);
	}
}
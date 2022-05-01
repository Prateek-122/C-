using System;
class tablewhile
{
	public static void Main(string [] args)
	{
		int i=1,a;
		System.Console.WriteLine("enter the number");
		a=Convert.ToInt32(Console.ReadLine());
		while(i<=10)
		{
			System.Console.WriteLine(i+"*"+a+"="+i*a);
			i++;
		}
	}
}
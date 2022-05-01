using System;
using System.Text;
class table
{
	public static void Main(string []args)
	{
	int a,i;
	System.Console.WriteLine("enter the number");
	a=Convert.ToInt32(Console.ReadLine());
	System.Console.WriteLine("result");
	for (i=1;i<=10;i++)
	{
		System.Console.WriteLine(a+"*"+i+"="+i*a);
	}
	}
}
using System;
using System.Text;
using System.Linq;
class oddeven 
{
	public static void Main(string []args)
	{
		try {
		int a;
		System.Console.WriteLine("enter the number");
		a=(int32)(Console.ReadLine());
		if(a%2==0)
		{
			System.Console.WriteLine("even");
		}
		else
		{
			System.Console.WriteLine("odd");
		}
		}catch(Exception ex)
		{
			Console.WriteLine (ex.Message);
		}
	}
}
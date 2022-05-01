using System;
using System.Text;
using System.Data;
class cal
{
	public static void Main(string []args)
	{
		decimal v1,v2;
		decimal sum;
		char op;
		System.Console.WriteLine("enter the first number");
		v1=Convert.ToInt16(Console.ReadLine());
		System.Console.WriteLine("enter second number");
		v2=Convert.ToDecimal(Console.ReadLine());
		System.Console.WriteLine("enter operators");
		op=Convert.ToChar(Console.ReadLine());
		if (op =='+')
		{
			sum=v1+v2;
			System.Console.WriteLine(String.Format("{0:0.00}",sum));
		}
		if (op =='-')
		{
			sum=v1-v2;
			System.Console.WriteLine(sum);
		}
		if (op =='*')
		{
			sum=v1*v2;
			System.Console.WriteLine(sum);
		}
		if (op =='/')
		{
			sum=v1/v2;
			System.Console.WriteLine(sum);
		}
		
		
	}
}
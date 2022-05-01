using System;
class findmin
{
	public static void Main(string []args)
	{
		int i=0;
		int num=0;
		Console.WriteLine("enter the value");
		   num=int.Parse(Console.ReadLine());
		int sum=0;
		int num1=0;
		while(i<num)
		{
			Console.WriteLine("enter the"+i+" number");
			num1=int.Parse(Console.ReadLine());
			if (i==0)
				sum=num1;
			if (num1<sum)
				sum=num1;
			i++;
		}
				Console.WriteLine(sum);
				
		
	}
}
using System;
class proccessoutput
{
	static void adds(int a,int b)
	{
		int c;
		c=a+b;
		Console.Write(c);
	}
	static void Main(string []args)
	{
		int x,y;
		Console.Write("enter 1");
		x=Convert.ToInt32(Console.ReadLine());
		Console.Write("enter 2");
		y=Convert.ToInt32(Console.ReadLine());
		//Console.Write(z);
		adds(x,y);
		
	}
}

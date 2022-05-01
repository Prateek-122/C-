using System;
class inputproccess
{
	static int adds()
	{
	int a,b,c;
	Console.Write("entre 1");
	a=Convert.ToInt32(Console.ReadLine());
	Console.Write("entre 2");
	b=Convert.ToInt32(Console.ReadLine());
	c=a+b;
	return c;
	}
		public static void Main(string []args)
		{
			int x;
			x=adds();
			Console.Write(x);
		}
	}
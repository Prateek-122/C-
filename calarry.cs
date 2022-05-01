using System;
class calarry
{
	public static void Main(string []args)
	{
		int a=int.Parse(args[0]);
		int b=Convert.ToInt32(args[1]);
		if (a>b)
			Console.WriteLine(a);
		else if (b>a)
			Console.WriteLine(b);
		else 
			Console.WriteLine("both are equial");
		
	}
}
		
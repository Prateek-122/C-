using System;
class largest 
{
	static void Main(string []args)
	{
		int a,b,c;
		System.Console.WriteLine("entre the first numbre");
		a=Convert.ToInt32(Console.ReadLine());
		System.Console.WriteLine("entre the second numbre");
		b=Convert.ToInt32(Console.ReadLine());
		System.Console.WriteLine("entre the third numbre");
		c=Convert.ToInt32(Console.ReadLine());
		if(a>b)
			if (a>c)
				System.Console.WriteLine("largest"+a);
			else 
				System.Console.WriteLine("largest"+c);
			else if(b>c)
				System.Console.WriteLine("largest"+b);
				else 
				System.Console.WriteLine("largest"+"  "+c);

			
		
	}
	
}
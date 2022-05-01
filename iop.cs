using System;
class iop
{
	  static void even()
	  {
	int a;
	Console.Write("enter the number");
	a=Convert.ToInt32(Console.ReadLine());
	if (a%2==0)
		Console.WriteLine(a+"  "+"even");
	else 
		Console.WriteLine(a+"  "+"odd");
	  }
	public static void Main(string []args)
	{
		even();
	}
		
}
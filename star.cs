using System;
class star
{
	public static void Main(string []args)
	{
	int i,j;
	 i=1;
	while(i<=7)
	{
		j=1;
		while(j<=i)
		{
			Console.Write("A");
			j++;
		}
		Console.WriteLine();
		i++;
	}
	}
}
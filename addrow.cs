using System;
class addrow
{
	public static void Main(string []args)
	{
		int i,j,sum=0;
		i=0;
		while(i<=5)
		{
			j=0;
			while(j<=5)
			{
				sum=sum+j;
				Console.Write(j);
				j++;
			}
			Console.WriteLine();
			if(i==0)
			break;
			i++;
		}
		Console.WriteLine(sum);
	}
}
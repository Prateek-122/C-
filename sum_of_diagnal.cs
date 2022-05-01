using System;
class sum_of_diagnal
{
	public static void Main(string []args)
	{
		int i,j,sum=0;
		Console.WriteLine("enter the size of row");
		int row=int.Parse(Console.ReadLine());
		Console.WriteLine("enter the size of col");
		int col=int.Parse(Console.ReadLine());
		int [,]arr= new int[row,col];
		Console.WriteLine("enter the element");
		for ( i=0;i<row;i++)
		{
			for ( j=0;j<col;j++)
			{
			arr[i,j]=int.Parse(Console.ReadLine());
			}
			Console.WriteLine();
		}
		for (i=0;i<row;i++)
		{
			for (j=0;j<col;j++)
			{
				Console.Write(arr[i,j]);
			}
			Console.WriteLine();
		}		
			for (i=0;i<row;i++)
			{ 
				 sum=0;
				for (j=0;j<=i;j++)
				{
					sum=arr[i,j]+sum;	
				}
					Console.WriteLine("sum of row="+sum);
			}				
	}
}
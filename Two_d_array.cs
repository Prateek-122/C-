using System;
class Two_d_array
{
	public static void Main(string [] args)
	{
		int row;
		Console.Write("enter the size of row");
		row=int.Parse(Console.ReadLine());
		int col;
		Console.Write("enter the size of column");
		col=int.Parse(Console.ReadLine());
		int [,]arr=new int[row,col];
		int i,j;
		for (i=0;i<row;i++)
		{
			for(j=0;j<col;j++)
			{
				Console.Write("{0}{1}"+"=",i,j);
				arr[i,j]=int.Parse(Console.ReadLine());
			}
			Console.WriteLine();
		}
		for (i=0;i<row;i++)
		{
			for (j=0;j<col;j++)
			{
				Console.Write(" "+arr[i,j]);
			}
			Console.WriteLine();
		}
	}
}
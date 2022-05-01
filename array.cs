using System;
class array
{
	public static void Main()
	{
		int size;
		Console.WriteLine("enter the size");
		size=int.Parse(Console.ReadLine());
		string[]arr=new string[size];
		int i;
		for (i=0;i<size;i++)
		{
			Console.WriteLine("enter the"+i+"latter");
			arr[i]=Console.ReadLine();
		}
		for (i=0;i<size;i++)
		{
			Console.Write(arr[i]);
		}
	}
}
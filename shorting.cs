using System;
class shorting
{
	public static void Main(string []args)
	{
	 int []arr={45,21,33,56,98,78,45,54,12,1,2,3,0,4};
		int i,j;
		int temp=0;
		for (i=0;i<arr.Length;i++)
		{
			for (j=i+1;j<arr.Length;j++)
			{
				if (arr[i]>arr[j])
				{
					temp=arr[i];
					arr[i]=arr[j];
					arr[j]=temp;
				}
			}
			Console.WriteLine(arr[i]);
		}
	}	
	}
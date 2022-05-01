using System; 
class averagenumber
{
	public static void Main(string []args)
	{
		int i=0;
		int valuee=0;
		int num=0;
		int max=0;
		Console.Write("enter the value");
		valuee=int.Parse(Console.ReadLine());
		while(i<valuee)
		{
			Console.WriteLine("enter the"+i+"number");
			num=int.Parse(Console.ReadLine());
			max=max+num;
			i++;
		}
			Console.WriteLine("result is ="+max);
	}
}
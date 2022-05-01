class Abc
{
		public static void Main(string []args)    {
		int count = 0;
        Console.WriteLine("enter the number");
		int n=int.Parse(Console.ReadLine());	
		if (n > 1)
		{
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
					count++;
			}
			if (count == 2)
				Console.WriteLine("prime no.");
				else
				Console.WriteLine("not prime no.");
		}
		else
			Console.WriteLine("not prime no.");
	}
}
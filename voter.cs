using System;
class voter
{
	static void Main(string []args)
	{
		int age=25;
		string country="indian";
		if (country=="indian")
			if (age>=18)
				Console.WriteLine("your are elgibal for vote");
				else 
					Console.WriteLine("your age is not complete");
				else 
					Console.WriteLine("your are not indian");
			
	}
}
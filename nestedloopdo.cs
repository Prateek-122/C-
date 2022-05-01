class nestedloopdo
{
	static void Main(string []args)
	{
		int i=0,j;
		do
		{
			j=0;
			do
			{
				System.Console.Write("*");
				j++;
			}
			while(j<5);
			System.Console.WriteLine();
			i++;
		}
		while(i<5);
		
	}
}
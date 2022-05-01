using System;
class demo
{
	static void Main(string []args)
	{
		int count=0,count1=0;
		Console.WriteLine("enter the number");
		string name=Console.ReadLine();
		for (int i=0;i<name.Length;i++)
		{
			if (name[i]=='A'||name[i]=='E'||name[i]=='O'||name[i]=='I'||name[i]=='U'||name[i]=='a'||name[i]=='e'||name[i]=='i'||name[i]=='o'||name[i]=='u')
				 count++;
			else 
				count1++;
		}
		Console.WriteLine("vowel"+count);
		Console.WriteLine("not vowel"+count1);
	}
}
using System;
class rever_number
{
    public static void Main(string [] args)
    {
       int i = 0;
        Console.WriteLine("enter the name");
        int number=int.Parse(Console.ReadLine());
       for( i=0;number!=0;i++)
        {
            number = number/ 10;
        }
        Console.WriteLine(i);
    }
}
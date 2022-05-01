using System;
using System.Text;
class UpperLower
{
    public static void Main(string [] args)
    {
        Console.WriteLine("entre the name");
        string name=Console.ReadLine();
        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());
    }
}
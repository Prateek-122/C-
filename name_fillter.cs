class Abc
{
    public static void Main(string []args)
    {
        string [] std=new string  [5];
        std[0] = "garima";
        std[1] = "bitu";
        std[2] = "situ";
        std[3] = "vishal";
        std[4] = "rajesh";
        Console.WriteLine("enter the latter");
        string l=Console.ReadLine();
        foreach(string s in std)
        {
            if (s.StartsWith(l))
            {
                Console.WriteLine(s);
            }
        }
    }
}
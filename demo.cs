using System;
namespace ConsoleApp1
{
    public class Demo
    {
      static string M(string n )
        {
            int i;
            for (i=0;i<n.Length;i++)
            {
                if (n[i] >= 'A'&&n[i]<='Z')
                        n[i] = (char)(n[i] + 32);
                   else if (n[i] >= 'a' && n[i]<='z')
                        n[i] = (char)(n[i] - 32);
            }
                             return n;  
        }
                    
            public static void Main(string []args)
        {
            string n = Console.ReadLine();
            
            Console.Write(M(n));
        }
    }
}

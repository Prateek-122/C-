using System;
using System.Text;

namespace myfirstproject
{
    internal class String_Builder
    {
        /*public static void Main()
        {
            StringBuilder sb=new StringBuilder("hello");
            sb.Append("prateek");
            sb.Append("rajeet");
            sb.AppendLine("kumar");
            sb.Append("yadav");
            sb.AppendFormat("hi");
            sb.Insert(5,"rana");
            sb.Remove(0, 5);
            StringBuilder it = new StringBuilder("hi");
            it.Append("git");
            it.Insert(1, "radhe");
            //it.Remove(1,5);
            it.Replace("git", "hi");
            string name=sb.ToString();
            Console.WriteLine(name);               
            Console.WriteLine(it);               
        }*/
        public static void Main()
        {
            Console.WriteLine("entre the name");
            string name=Console.ReadLine();
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Substring(5));
            Console.WriteLine(name.Substring(10,9));

        }

    }
}

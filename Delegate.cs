/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    public delegate void MyDelegate(string msg);

        class Prateek
    {
        public static void Main(string[] args)
        {
            Prateek1 obj = new Prateek1();
            MyDelegate myDelegate = new MyDelegate(obj.Method);
            myDelegate.Invoke("hello");
            myDelegate = myDelegate + obj.Method;
        }
        class Prateek1
        {
            public  void  Method(string msg)
            {
                Console.WriteLine("hi");
            }
        }
        class Prateek2
        {
            public static void Method2()
            {

            }
        }
    }
}*/
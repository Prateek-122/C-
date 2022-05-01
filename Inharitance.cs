using System;
namespace Prateek1
{
    class dadaji
    {
        public static void M4()
        {
            Console.WriteLine("dadaji");
        }
        private void M5()
        {
            Console.WriteLine("dada");                     
        }
        protected void M6()
        {
            Console.WriteLine("ji");
        }
    }
    class papa : dadaji
    {
        public  void M()
        {
            Console.WriteLine("papa");
            papa p = new papa();
            M4();
        }
    }
    class mummy:papa
    {
        public static  void M1()
        {
            mummy m=new mummy();
            Console.WriteLine("mummy");
            m.M();

        }
    }
    class beta
    {
        public static void M2()
        {
            Console.WriteLine("mummy");
        }






    }
}

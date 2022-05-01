using System;
using System.Collections.Generic;
using System.Collections;
//list
/*class Abc
{
    public static void Main(string[] args)
    {
        var student = new List<string>();
        student.Add("situ");
        student.Add("bitu");
        student.Add("rita");
        student.Add("ram");
        student.Add("prateek");
        student.Add("ranjeet");
        student.Add("vishal");
        student.Add("rajesh");
        student.Add("rajesh");
        foreach (var i in student)
        {
            Console.WriteLine(i);
        }
    }
}*/

//stack
/*class Abc
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------push(last in first out)---------------------------------------");
        //push_Stack
        Stack<string> Student = new Stack<string>();
        Student.Push("situ");
        Student.Push("situ");
        Student.Push("rita");
        Student.Push("bitu");
        foreach (var i in Student)
        {
            Console.WriteLine(i);
        }
        //Pop_Stack
        Console.WriteLine("--------------------------pop(last in first out, but always left the fisrt element enter in pop )------------------------------------");
        Student.Pop();
        foreach (var i in Student)
        {
            Console.WriteLine(i);
        }

    }
}*/

//Queue_Enqueue-(fisr in first out)
/*class Abc
{
    public static void Main(string[] args)
    {
        Queue<string> name = new Queue<string>();
        name.Enqueue("bitu");
        name.Enqueue("situ");
        name.Enqueue("rita");
        name.Enqueue("gita");
        foreach (var i in name)
        {
            Console.WriteLine(i);
        }
        //Queue_Dequeue-(fisrt in first out, but always left the fisrt element enter ) 
        Console.WriteLine("--------------------pop--------------------------------");
        name.Dequeue();
        foreach (var i in name)
        {
            Console.WriteLine(i);
        }
    }
}
*/
//hashSet
/*class Abc
{
    public static void Main(string[] args)
    {
        var Student = new HashSet<string>();
        Student.Add("situ");
        Student.Add("bitu");
        Student.Add("rita");
        Student.Add("rita");
        Student.Add("gita");
        Console.WriteLine("Student name ");
        foreach (var i in Student)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("enter the name");
        string s = Console.ReadLine();
        Student.Remove(s);
        Console.WriteLine("remove name");
        foreach (var i in Student)
        {
            Console.WriteLine(i);
        }

    }
}*/
//Sorting_set
/*class Abc
{
    public static void Main(string[] args)
    {
        var Student = new SortedSet<string>();
        Student.Add("situ");
        Student.Add("aman");
        Student.Add("bitu");
        Student.Add("gita");
        foreach (var i in Student)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("remove the element");
        string s = Console.ReadLine();
        Student.Remove(s);
        Console.WriteLine("namer is remove");
        foreach (var i in Student)
        {
            Console.WriteLine(i);
        }
    }
}*/

//Linked_List
/*class Abc
{
    public static void Main()
    {
        var Student = new LinkedList<string>();
        Student.AddLast("situ");
        Student.AddLast("bitu");
        Student.AddLast("ranjeet");
        Student.AddLast("vishal");
        Student.AddLast("situ");
        Student.AddLast("garima");
        Student.AddFirst("rajesh");
        Console.WriteLine("After the Add elemnt");
        LinkedListNode<string> node = Student.Find("vishal");
        Student.AddBefore(node, "gopalji");
        Student.AddAfter(node, "gopal");
        foreach (var i in Student)
        {
            Console.WriteLine(i);
        }
    }
}*/
//Dictionary
/*class Abc
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> Student = new Dictionary<int, string>();
        Student.Add(1,"amaan");
        Student.Add(2, "rohan");
        Student.Add(3, "sita");
        Student.Add(4, "gita");
        Student.Add(6, "gita");
        Student.Add(5, "prateek");
        foreach (KeyValuePair<int, string> i in Student)
        {
            Console.WriteLine(i.Key + "  " + i.Value);
        }
    }
}*/
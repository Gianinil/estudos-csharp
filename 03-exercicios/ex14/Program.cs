using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Ana");

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
        
        Console.WriteLine("List count: " + list.Count);

        Console.WriteLine("_________________________________________");
        
        list.Insert(0, "Bob");

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("List count: " + list.Count);

        Console.WriteLine();

        string s1 = list.Find(Test);
        Console.WriteLine("First 'A': " + s1);
        
        string s2 = list.Find(x => x[0] == 'B');
        Console.WriteLine("First 'B': " + s2);
        
        string s3 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine("Last 'A': " + s3);
        
    }

    static bool Test(string s)
    {
        return s[0] == 'A';
    }
}
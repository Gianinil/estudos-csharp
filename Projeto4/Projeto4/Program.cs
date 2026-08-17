using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        Console.WriteLine(a);

        a += 2;
        Console.WriteLine(a);

        int b = 10;
        Console.WriteLine(b);

        b -= 2;
        Console.WriteLine(b);

        a *= 3;
        Console.WriteLine(a);

        string s = "abc";
        s += "def";
        Console.WriteLine(s);

        a++;
        Console.WriteLine(a);

        a--;
        Console.WriteLine(a);

        a = 0;
        int c = a++;
        Console.WriteLine(a);
        Console.WriteLine(c);

        a = 0;
        c = ++a;
        Console.WriteLine(a);
        Console.WriteLine(c);

    }
}


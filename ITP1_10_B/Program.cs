using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var a = int.Parse(input[0]);
        var b = int.Parse(input[1]);
        var C = int.Parse(input[2]);

        var sin = Math.Sin(C * (Math.PI / 180));
        var cos = Math.Cos(C * (Math.PI / 180));

        var S = 0.5 * a * b * sin;
        var L = a + b + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * cos);
        var h = b * sin;
       
        Console.WriteLine("{0}\n{1}\n{2}", S, L, h);   
    }
}
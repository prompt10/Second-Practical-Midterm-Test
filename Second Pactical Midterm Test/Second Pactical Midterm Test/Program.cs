using System;

namespace Second_Pactical_Midterm_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            Console.Write("Please input a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please input b: ");
            b = int.Parse(Console.ReadLine());

            x = a;
            y = b;
            while (x != y)
            {
                if (x < y) 
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            Console.WriteLine();
            Console.WriteLine(x);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyCapp.Example
{
    class ExampleOne
    {
        static void Main()
        {
            Console.Write("Please Enter the  Number 1 ");
            int x = int.Parse (Console.ReadLine());

            Console.Write("Please Enter the Number 2 ");
            int y = int.Parse(Console.ReadLine());

            int z =x + y;

            Console.Write(" The sum of the numbers {0} and {1} is Equal to {2}", x, y, z);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
namespace BoxUnboxIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> Box = new List<object>();
            //add some stuff to my list
            Box.Add(7);
            Box.Add(28);
            Box.Add(-1);
            Box.Add(true);
            Box.Add("chair");

            foreach (object val in Box)
            {
                System.Console.Write($"{val} ");
            }
            System.Console.WriteLine();

            var sum = 0;
            foreach (object num in Box)
            {
                if (num is int)
                {
                    int temp = (int)num;
                    sum += temp;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}

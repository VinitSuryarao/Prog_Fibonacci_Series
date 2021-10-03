using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        //   Fibonacci Series
        // Number = 5 then Seris is 0 1 1 2 3
        // Sum of two number will be next number

        static void Main(string[] args)
        {
            int n=6, a = 0, b = 1, temp;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                temp = a;
                a = b;
                b = temp + b;
            }
            
        }
    }



using System;
using System.Linq;
using System.Collections.Generic;

namespace treinolinq
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
            int[] numbers = new int[]
            {
                1, 2, 3, 4, 5, 6, 8, 9, 10
            };

            var result = numbers.Where(x => x % 2 == 0).Select(x => x*10);
            // seleciona com lambda apenas os pares e depois multiplico por 10.

            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
using System;
using System.Linq;

namespace CSharpPractice
{
    class LINQQueryPractice
    {
        static void Main(string[] args)
        {
            //query dataSource
            int[] array = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //query declaration
            var numQuery = ((
                from num in array
                where (num % 2) == 0
                select num).ToList());

            foreach (var item in numQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}

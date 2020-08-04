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

            //query declaration query syntax
            var numQuery = ((
                from num in array
                where (num % 2) == 0
                orderby num descending                                 //ordered by descending practice
                select num).ToList());

            //method Syntax
            var Query = array.Where(num => num % 2 == 0).OrderBy(num => num);       //orderby is defaultly ascending

            foreach (var item in numQuery)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(System.Environment.NewLine);

            foreach (var item in Query)
            {
                Console.Write(item + " ");
            }
        }
    }
}

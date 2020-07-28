using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPractice
{
    class PerformingOperationsOnSourceElements
    {

        static void Main(String[] args)
        {
            double[] radius = { 1, 2, 3 };

            //Query Syntax
            IEnumerable<string> output =
              from rad in radius
              select $"Area for a circle with a radius of '{rad}' = {rad * rad * Math.PI}";      //LINQ Query using query syntax

            //LinQ Query using Method Syntax
            //IEnumerable<string> out = 

            //     radius.Select(rad => $"Area of circle of radius '{rad}' = {rad * rad* Math.PI:F2}");


            foreach (var item in output)
            {
                Console.WriteLine(item);
            }


        }

    }
}
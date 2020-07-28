using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPractice
{
    class DataTransformation
    {
        class student
        {
            public string Name { get; set; }
            public string place { get; set; }

        }

        class Teacher
        {
            public string Name { get; set; }
            public string place { get; set; }

        }

        public static void Main(String[] args)
        {
            //Creation of datasource
            List<student> students = new List<student>()
            {
                new student
                {
                    Name = "Reshma",
                    place = "chennai"
                },
                new student
                {
                    Name = "Masudha",
                    place = "trichy"
                },
                new student
                {
                    Name = "Aisha",
                    place = "coimbatore"
                }
            };

            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher
                {
                    Name = "Nasreen",
                    place = "Canada"

                },
                 new Teacher
                {
                    Name = "Zeeshan",
                    place = "chennai"

                },
                  new Teacher
                {
                    Name = "Banu",
                    place = "trichy"

                }
            };

            //creation of query

            var query =
             ((
                 from student in students
                 where student.place == "chennai"
                 select student.Name).Concat(from Teacher in teachers
                                             where Teacher.place == "chennai"
                                             select Teacher.Name));
            //execution of query

            Console.WriteLine("People in chennai:");

            foreach (var item in query)
            {
                Console.WriteLine(item);              //writes output of people in chennai
            }

        }
    }
}

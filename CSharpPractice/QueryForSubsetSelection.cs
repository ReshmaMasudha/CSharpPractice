using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPractice
{
    class QueryForSubsetSelection
    {
        #region SameDataSource

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

            #endregion

            var Query1 =
                (from student in students
                 select student.place);

            var Query2 =
               (from student in students
                select new { Name = student.Name, place = student.place });

            foreach (var item in Query1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in Query2)
            {
                Console.WriteLine(item);
            }
        }

    }
}

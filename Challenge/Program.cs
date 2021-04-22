using System;
using System.Collections.Generic;
namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> grades = new List<int>();
            List<string> names = new List<string>();

            Console.WriteLine("Student Name: ");
            string name = Console.ReadLine();
            names.Add(name);

            Console.WriteLine("Student Grade: ");
            int grade = int.Parse(Console.ReadLine());
            grades.Add(grade);
            int count = 0;
            for (int i = 1; i > 0; i++)
            {

                Console.WriteLine("Add Another student: Yes/No");
                string choose = Console.ReadLine();
                if (choose == "Yes" || choose == "yes")
                {
                    Console.WriteLine("Student Name: ");
                    name = Console.ReadLine();
                    names.Add(name);

                    Console.WriteLine("Student Grade: ");
                    grade = int.Parse(Console.ReadLine());
                    grades.Add(grade);
                }
                else if (choose == "No" || choose == "no")
                {
                    for (int x = 0; x < names.Count; x++)
                    {
                        Console.WriteLine("Student name: " + names[x] + ", "+ "Student grade: " + grades[x]);
                       
                    }

                    Console.WriteLine("Enter the grade to search: ");
                    int s1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Number of student with grade " + s1 + " is " + search(grades, s1));
                    break;

                }

                count++;

            }
        }

        public static int search(List<int> listGrade, int s)
        {
            
            int c = 0;
            for (int e = 0; e < listGrade.Count; e++)
            {
                if (listGrade[e] == s)
                {
                    c++;
                }

            }
            return c;
           


        }
    }
}



    




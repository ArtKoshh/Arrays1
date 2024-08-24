using System;


namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 10;
            grades[2] = 5;
            grades[3] = 7;
            grades[4] = 12;
            grades[5] = 24;
            Console.WriteLine("Grades at index 0 : {0}", grades[0]);
            

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("Grades at index 0 : {0}", grades[0]);
            Console.ReadKey();


            int[] gradesofMathStudentsA = { 20, 10, 5, 7, 9 };


            int[] gradesofMathStudentsB = new int[] { 15, 20, 3, 4, 5, 6 };

            Console.WriteLine("Length of Student Class A {0}",gradesofMathStudentsA.Length);
            Console.ReadKey();
        }



    }
}
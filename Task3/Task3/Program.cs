using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {


            string fullName;
            string groupNo;

            do
            {
                Console.Write("Write your FullName: ");
                fullName = Console.ReadLine();
            }
            while (!Student.CheckFullname(fullName));

            do
            {
                Console.Write("Write your Group: ");
                groupNo = Console.ReadLine();
            }
            while (!Student.CheckGroupNo(groupNo));

            Console.Write("Write your age: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("");

            Student student = new Student(fullName, groupNo, age);
            student.Info();




        }

    }
}

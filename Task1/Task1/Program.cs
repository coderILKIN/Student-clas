using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(IsOdd(22));

            

           // Console.WriteLine(isEven(28));

        }


        public static int IsOdd(int num)
        {
            if (num%2==1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            return num;
        }

        public static int isEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            return number;
        }

    }
}

namespace TuesdayHomeWork
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public static class HomeTask
    {
        public static void GetTask1()
        {
            Console.WriteLine("Task 1.1\nInput a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a + b = {0}\na - b = {1}\na * b = {2}\na / b = {3}", a + b, a - b, a * b, (double)a / (double)b);
        }

        public static void GetTask2()
        {
            Console.WriteLine("\n\nTask 1.2\nHow are you?");
            string str = Console.ReadLine();

            Console.WriteLine("You are {0}", str);
        }

        public static void GetTask3()
        {
            char[] ch = new char[3];
            Console.WriteLine("\n\nTask 1.3\nYou are working with char array!!!");

            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine("Please type {0} element", i);
                ch[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("\n");

            foreach (var data in ch)
            {
                Console.WriteLine("You enter " + data);
            }
        }

        public static void GetTask4()
        {
            Console.WriteLine("\n\nTask 1.4\nInput A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && b >= 0)
            {
                Console.WriteLine("A and B are positive");
            }
            else
            {
                Console.WriteLine("A and/or B are negative");
            }
        }
    }
}

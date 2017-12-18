namespace TuesdayHomeWork
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public static class HomeWork
    {
        public static void GetHW1()
        {
            Console.WriteLine("\nHomeWork");
            int a = 5;
            Console.Write("\na = {0}. Please type b\nb = ", a);
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square is {0}, Perimiter is {1}", a * b, (a + b) * 2);
        }

        public static void GetHW2()
        {
            string name = "Serhiy";
            int age = 24;
            Console.WriteLine("\n\nWhat is your name?\n" + name);
            Console.WriteLine("How old are you, {0}?\n{1}", name, age);
        }

        public static void GetHW3()
        {
            Console.Write("\nInput double r = ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lenght is " + (2 * Math.PI * r));
            Console.WriteLine("Area is " + (Math.PI * Math.Pow(r, 2)));
            Console.WriteLine("Volume is " + ((4 / 3) * Math.PI * Math.Pow(r, 3)));
        }
    }
}
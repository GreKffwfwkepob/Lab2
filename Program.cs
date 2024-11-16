using System;

namespace Lab2
{
    class Programm
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Enter A");
            Console.WriteLine("Enter B");
            Console.WriteLine("Perform the operation \"+\"");
            Console.WriteLine("Perform the operation \"-\"");
            Console.WriteLine("Perform the operation \"*\"");
            Console.WriteLine("Perform the operation \"/\"");


        }

        private static double InputA()
        {
            Console.Write("Enter A: ");
            return Convert.ToDouble(Console.ReadLine());

        }

        private static double add()
        {
            Console.Write("Perform the operation \"+\"");
            return Convert.ToDouble(Console.ReadLine());

        }

    }
}


// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

//Console.WriteLine("Hello, World!");


namespace calculator

  
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n, m;
                string operand;

                Console.Write("Type  first number, and then press Enter \n");
                n = int.Parse(Console.ReadLine());

                Console.Write("Type second number , and then press Enter \n");
                m = int.Parse(Console.ReadLine());

                Console.WriteLine("Select the operation");
                Console.WriteLine(" + - add");
                Console.WriteLine(" - - Minus");
                Console.WriteLine(" * - Multiply");
                Console.WriteLine(" /- Divide");
                Console.WriteLine("Your Operation?");

                operand = Console.ReadLine();
                switch (operand)
                {
                    case "+":
                        Console.WriteLine("\t {x}+{y}=" + Sum(n, m));
                        break;
                    case "-":
                        Console.WriteLine("\t {x}-{y}=" + Minus(n, m));
                        break;
                    case "*":
                        Console.WriteLine("\t {x}*{y}=" + Multiple(n, m));
                        break;
                    case "/":
                        Console.WriteLine("\t {x}/{y}=" + Divide(n, m));
                        break;

                    default:
                        Console.WriteLine("\t the operand is wrong...");
                        break;


                }
            }

            Console.ReadKey();

        }
        public static int Sum(int n, int m)
        {

            return n + m;

        }
        static int Minus(int n, int m)
        {
            return n - m;

        }
        static int Multiple(int n, int m)
        {
            return n * m;
        }
        static double Divide(int n, int m)
        {
            return n / (double)m;
        }



    }
}



using System;
using Methods;
namespace DllJenkin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Enter number 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 1: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            MyMaths m = new MyMaths();

            Console.WriteLine($"Addition of {n1} and {n2} is : {m.Add(n1, n2)}");

            Console.WriteLine($"Multiplication of {n1} and {n2} is : {m.Mul(n1, n2)}");

            Console.ReadKey();
        }
    }
}

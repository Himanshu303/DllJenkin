using System;
using Methods;
namespace DllJenkin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            n1 = 5;
            n2 = 7;
            MyMaths m = new MyMaths();

            Console.WriteLine(m.Add(n1, n2));

            Console.WriteLine(m.Mul(n1, n2));
        }
    }
}

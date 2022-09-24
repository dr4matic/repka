using System;

namespace curkemur
{
    class Program
    {
        static void Main(string[] args)
        {
            var kalkulator = new Kalkulator();
            var res = kalkulator.Calculate(Console.ReadLine());
            Console.WriteLine(res);
         }           
    }
}


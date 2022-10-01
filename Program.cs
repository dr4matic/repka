using System;

namespace kod
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = new Calculator();
            var resault = calculate.Calculate("-21+11+31231312321-12321312");
            Console.WriteLine(resault);
        }
    }
}

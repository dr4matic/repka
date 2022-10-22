using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__100
{
    class _100
    {
        public void Print<B>(B znach)
        {
            var glek = Console.BackgroundColor;
            if (typeof(string) == znach.GetType())
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            if (typeof(int) == znach.GetType())
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(znach);
            Console.BackgroundColor = glek;
        }

    }
}

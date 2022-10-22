using System;

namespace _1__100
{
    class Program
    {
        static void Main(string[] args)
        {
            
            _100 pepe = new _100();
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    pepe.Print((char)i);
                }
                else if (i % 2 == 0)
                {
                    pepe.Print(i.ToString());
                }
                else
                {
                    pepe.Print(i);
                }
            }
        }
    }
}

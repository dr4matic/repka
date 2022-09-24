using System;

namespace ConsoleApp2
{
    class Program 
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter first number: ");
            var pau = int.TryParse(Console.ReadLine(), out var pepe);
            Console.WriteLine();
            Console.Write("Enter second number: ");
            var chikichiki = int.TryParse(Console.ReadLine(), out var monke);
            Console.WriteLine();
            var karlik = Console.ReadKey();
            switch (karlik.KeyChar)
            {
                case '+':
                    {
                        var babijon = pepe + monke;
                        Console.Write("\n Result 2: ");
                        Console.WriteLine(babijon);
                    }
                    break;
                case '-':
                    {
                        var babijon = pepe - monke;
                        Console.Write("\n Result 2: ");
                        Console.WriteLine(babijon);
                    }
                    break;
                case '*':
                    {
                        var babijon = pepe * monke;
                        Console.Write("\n Result 2: ");
                        Console.WriteLine(babijon);
                    }
                    break;
                case '%':
                    {
                        var babijon = pepe % monke;
                        Console.Write("\n Result 2: ");
                        Console.WriteLine(babijon);
                    }  
                    break;
                default: throw new Exception("Челик ты совершил ошибку");
            }
        }
    }
}
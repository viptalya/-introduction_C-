using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя");

            var name = Console.ReadLine();

            var date = DateTime.Now;

            Console.WriteLine($"Здравствуйте {name}, сейчас {date}");
        }
    }
}

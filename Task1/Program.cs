using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            var name = Console.ReadLine();       // вводим имя
            Console.WriteLine($"Привет {name}");    // выводим имя на консоль
        }
    }
}

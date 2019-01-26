using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя.");
            var name = Console.ReadLine();
            Console.WriteLine("Введите фамилию.");
            var surname = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            var age = Console.ReadLine();
            Console.WriteLine("Введите ваш рост в метрах");
            double f = Convert.ToDouble(Console.ReadLine()); //не принимает десятичные дроби, не знаю как исправить.
            Console.WriteLine("Введите ваш вес в кило");
            int m = Convert.ToInt32(Console.ReadLine());

            double i1 = f * f;
            double i2 = m / i1;
         
            
            Console.Write("Ваше имя - " + name + ".");
            Console.Write($"Ваша фамилия - {surname}.");
            Console.Write("Ваш возраст - {0}.", age);
            Console.Write($"Ваш рост - {f}.");
            Console.Write($"Ваш вес - {m}.");
            Console.Write($"Ваш ИМТ - {i2}.");
            
            Console.ReadKey();
        }
    }
}
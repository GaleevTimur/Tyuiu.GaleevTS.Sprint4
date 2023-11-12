using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GaleevTS.Sprint4.Task6.V29.Lib;

namespace Tyuiu.GaleevTS.Sprint4.Task6.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт №4 | Выполнил: Галеев Т. С. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Класс Array                                                        *");
            Console.WriteLine("* Задание №6                                                               *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнил: Галеев Тимур Серикович | ИИПб-23-3                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");

            var season = new string[] { "Весна", "Лето", "Осень", "Зима" };
            Console.WriteLine("Исходный массив");
            for (int i = 0; i <= season.Length - 1; i++)
            {
                Console.WriteLine(season[i]);
            }
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            int nums = ds.Calculate(season);
            Console.WriteLine(nums);

            Console.ReadKey();
        }
    }
}

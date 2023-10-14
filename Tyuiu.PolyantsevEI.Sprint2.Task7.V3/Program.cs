using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PolyantsevEI.Sprint2.Task7.V3.Lib;

namespace Tyuiu.PolyantsevEI.Sprint2.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Полянцев Е. И. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Полянцев Егор Ильич | ИСТНб-23-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает значения с клавиатуры и         *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение координаты X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение координаты Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res) Console.WriteLine("Точка находится в заштрихованной области");
            else Console.WriteLine("Точка не находится в заштрихованной области");

            Console.ReadKey();
        }
    }
}

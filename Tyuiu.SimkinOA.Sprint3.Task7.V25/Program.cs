﻿using Tyuiu.SimkinOA.Sprint3.Task7.V25.Lib;
namespace Tyuiu.SimkinOA.Sprint3.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Симкин О.А. | Рппб-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Симкин Олег Андреевич | Рппб-25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*                                                                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("введите начальное значение отрезка: ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите конечное значение отрезка: ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetMassFunction(startValue, stopValue);

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
            
            Console.ReadKey();
        }
    }
}
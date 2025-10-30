using Tyuiu.Simkin.Sprint3.Task0.V18.Lib;
namespace Tyuiu.Simkin.Sprint3.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил : Симкин Олег Андреевич | Рппб-25-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                         *");
            Console.WriteLine("* Тема: Оператор цикла for                                                          *");
            Console.WriteLine("* Задание #0                                                                        *");
            Console.WriteLine("* Вариант #18                                                                       *");
            Console.WriteLine("* Выполнила: Выполнил : Симкин Олег Андреевич | Рппб-25-1                           *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать прогарммму используя цикла for, которая вычисляет произведение ряда      *");
            Console.WriteLine("* по формуле, при Х=1                                                               *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 6;

            Console.WriteLine("Переменная Х = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Произведение ряда =" + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}

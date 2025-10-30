
namespace Tyuiu.SimkinOA.Sprint3.Task2.V25;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Симкин О.А. | Рппб-25-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #2                                                           *");
        Console.WriteLine("* Вариант #25                                                          *");
        Console.WriteLine("* Выполнил: Симкин Олег Андреевич  | Рппб-25-1                         *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");


        int value = 5;
        int startValue = 1;
        int stopValue = 13;
        Console.WriteLine("X:" + value);
        Console.WriteLine("старт шага:" + startValue);
        Console.WriteLine("конец шага:" + stopValue);


        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine($"Ответ = " + ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadKey();
    }
} 
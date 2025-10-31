using Tyuiu.SimkinOA.Sprint3.Task3.V11.Lib;
namespace Tyuiu.SimkinOA.Sprint3.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Симкин О.А.| РППб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Оператор цикла foreach                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Симкин Олег Андреевич | РППб-25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы q на цифру 7 в строке             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Строка: sqwreq vqwqq q");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string value = "sqwreq vqwqq q";
            DataService ds = new DataService();
            string res = ds.ReplaceCharOnNum(value, 'q', '7');
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
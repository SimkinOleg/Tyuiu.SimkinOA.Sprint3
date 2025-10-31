using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SimkinOA.Sprint3.Task6.V30.Lib
{
    public class DataService : ISprint3Task6V30
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalCount = 0;

            for (int number = startValue; number <= stopValue; number++)
                for (int divisor = 1; divisor <= number; divisor++)
                    if (number % divisor == 0)
                        totalCount++;

            return totalCount;
        }
    }
}
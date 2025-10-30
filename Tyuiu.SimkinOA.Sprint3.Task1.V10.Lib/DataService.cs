using tyuiu.cources.programming.interfaces.Sprint3; 
namespace Tyuiu.SimkinOA.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            int i = startValue;
            double s = 0;
            while (i <= stopValue)
            {
                s += Math.Pow((1.0 / (i + Math.Pow(value, i))), i);
                i++;
            }
            return Math.Round(s, 3);
        }
    }
}
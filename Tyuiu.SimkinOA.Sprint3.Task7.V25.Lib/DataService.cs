using tyuiu.cources.programming.interfaces.Sprint3;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SimkinOA.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            Func<double, double> f = x => Math.Cos(x) + 4 * x / 2 - Math.Sin(x) * 3 * x;

            double step = 1;
            double[] values = new double[(stopValue - startValue) + 1]; 

            int i = 0;
            for (double x = startValue; x <= stopValue; x += step)
            {
                values[i] = Math.Round(f(x), 2);
                i++; 
            }

            return values;
        }
    }
}
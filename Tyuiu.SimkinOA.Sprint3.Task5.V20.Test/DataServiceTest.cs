using Tyuiu.SimkinOA.Sprint3.Task5.V20.Lib;
namespace Tyuiu.SimkinOA.Sprint3.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeriesTest()
        {
            DataService ds = new DataService();
            int startValue1, startValue2 = startValue1 = 1;
            int stopValue1 = 3;
            int stopValue2 = 6;
            int x = 5;

            double wait = 50584.322;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(wait, res);
        }
    }
}
using Tyuiu.SimkinOA.Sprint3.Task4.V15.Lib;
namespace Tyuiu.SimkinOA.Sprint3.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(2.591, ds.Calculate(-1, 0));
        }
    }
}
using Tyuiu.DunaizevAO.Sprint3.Task0.V28.Lib;

namespace Tyuiu.DunaizevAO.Sprint3.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0;
            int startValue = 1;
            int stopValue = 17;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 131072;
            Assert.AreEqual(wait, res);
        }
    }
}

using Tyuiu.DunaizevAO.Sprint3.Task2.V25.Lib;

namespace Tyuiu.DunaizevAO.Sprint3.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 5;
            int b = 1;
            int c = 13;
            double wait = 16;
            var res = ds.GetSumSeries(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}

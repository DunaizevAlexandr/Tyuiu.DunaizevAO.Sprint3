using Tyuiu.DunaizevAO.Sprint3.Task1.V2.Lib;

namespace Tyuiu.DunaizevAO.Sprint3.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 1;
            int b = 15;
            double wait = 0.967;
            var res = ds.GetSumSeries(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}

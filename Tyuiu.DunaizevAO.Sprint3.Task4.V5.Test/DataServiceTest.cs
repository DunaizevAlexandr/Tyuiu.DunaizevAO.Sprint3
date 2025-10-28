using Tyuiu.DunaizevAO.Sprint3.Task4.V5.Lib;

namespace Tyuiu.DunaizevAO.Sprint3.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5;
            int b = 5;
            double wait = -0,858;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}

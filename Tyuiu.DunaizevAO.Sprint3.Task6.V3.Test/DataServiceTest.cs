using Tyuiu.DunaizevAO.Sprint3.Task6.V3.Lib;

namespace Tyuiu.DunaizevAO.Sprint3.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 13;
            int b = 19;
            int wait = 121;
            var res = ds.GetSumTheDivisors(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}

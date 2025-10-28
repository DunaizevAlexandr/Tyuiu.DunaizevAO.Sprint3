using Tyuiu.DunaizevAO.Sprint3.Task3.V21.Lib;

namespace Tyuiu.DunaizevAO.Sprint3.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = "f3g5ht g4j 34kg4";
            char b = 'e';
            string wait = "fegeht gej eekge";
            var res = ds.ReplaceNumOnChar(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}

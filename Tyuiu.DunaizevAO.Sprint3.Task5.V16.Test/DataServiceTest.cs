namespace Tyuiu.DunaizevAO.Sprint3.Task5.V16.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int a = 2;
        int b = 1;
        int c = 3;
        int d = 1;
        int e = 10;
        int wait = 0;
        var res = ds.GetSumSumSeries(a, b, c, d, e);
        Assert.AreEqual(wait, res);
    }
}

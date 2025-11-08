using Tyuiu.PolyakovaAS.Sprint1.Task4.V9.Lib;
namespace Tyuiu.PolyakovaAS.Sprint1.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            double wait = 1.183;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

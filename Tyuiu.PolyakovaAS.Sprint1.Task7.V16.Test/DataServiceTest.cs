using Tyuiu.PolyakovaAS.Sprint1.Task7.V16.Lib;
namespace Tyuiu.PolyakovaAS.Sprint1.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 1.022;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}

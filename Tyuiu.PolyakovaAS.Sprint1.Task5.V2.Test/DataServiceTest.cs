using Tyuiu.PolyakovaAS.Sprint1.Task5.V2.Lib;
namespace Tyuiu.PolyakovaAS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double t = 200;
            var res = 93;
            Assert.AreEqual(res, ds.FahrenheitToСelsius(t));
        }
    }
}

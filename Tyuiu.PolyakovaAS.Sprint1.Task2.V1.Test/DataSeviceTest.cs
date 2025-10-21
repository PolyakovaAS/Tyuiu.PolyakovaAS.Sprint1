


using Tyuiu.PolyakovaAS.Sprint1.Task2.V1.Lib;

namespace Tyuiu.PolyakovaAS.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataSeviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int km = 1609;
            var res = ds.ConvertKmToM(km);
            double wait = 2588.881;
            Assert.AreEqual(wait, res);


        }
    }
}

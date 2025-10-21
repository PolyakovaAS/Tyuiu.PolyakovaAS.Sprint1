


using Tyuiu.PolyakovaAS.Sprint1.Task3.V13.Lib;

namespace Tyuiu.PolyakovaAS.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double number = 2;

            double wait = 8;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(wait, res);

        }
    }
}

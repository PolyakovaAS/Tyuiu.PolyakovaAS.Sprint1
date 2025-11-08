using Tyuiu.PolyakovaAS.Sprint1.Task6.V4.Lib;
namespace Tyuiu.PolyakovaAS.Sprint1.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "На свете есть много интересных вещей, но некоторые из них особенно занимательны";
            string res = ds.CheckDoubleN(value);
            Assert.AreEqual("особенно", res);

        }
    }
}

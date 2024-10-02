using Tyuiu.BorkovNA.Sprint1.Task5.V3.Lib;


namespace Tyuiu.BorkovNA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0, ds.Calculate(13048));
        }
    }
}
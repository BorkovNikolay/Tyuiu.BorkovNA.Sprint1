using Tyuiu.BorkovNA.Sprint1.Task4.V22.Lib;


namespace Tyuiu.BorkovNA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.054, ds.Calculate(2, 2));
        }
    }
}
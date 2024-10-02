using Tyuiu.BorkovNA.Sprint1.Task7.V16.Lib;


namespace Tyuiu.BorkovNA.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.026, ds.Calculate(5));
        }
    }
}
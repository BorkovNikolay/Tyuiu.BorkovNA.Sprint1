using Tyuiu.BorkovNA.Sprint1.Task2.V18.Lib;

namespace Tyuiu.BorkovNA.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateSideSquareParallelepiped()
        {
            DataService ds = new DataService();
            Assert.AreEqual(16, ds.CalculateSideSquareParallelepiped(2, 2, 2));
        }
    }
}
using Tyuiu.BorkovNA.Sprint1.Task1.V29.Lib;

namespace Tyuiu.BorkovNA.Sprint1.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3,3,3);
            Assert.AreEqual(3, res);
        }
    }
}
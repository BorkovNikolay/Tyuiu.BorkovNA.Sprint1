using Tyuiu.BorkovNA.Sprint1.Task6.V7.Lib;

namespace Tyuiu.BorkovNA.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteLastLetter()
        {
            string a = "Привет мир";
            string b = "Приве ми";
            DataService ds = new DataService();
            Assert.AreEqual(b, ds.DeleteLastLetter(a));
        }
    }
}
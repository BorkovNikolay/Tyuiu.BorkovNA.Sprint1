using Tyuiu.BorkovNA.Sprint1.Task3.V1.Lib;


namespace Tyuiu.BorkovNA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCylinderVolume()
        {
            DataService ds = new DataService();
            Assert.AreEqual(3.142, ds.CylinderVolume(1, 1));
        }
    }
}
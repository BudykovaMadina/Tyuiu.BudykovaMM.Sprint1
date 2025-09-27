using Tyuiu.BudykovaMM.Sprint1.Task2.V9.Lib;
namespace Tyuiu.BudykovaMM.Sprint1.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 3;
            var res = ds.CalculateVolumeCircle(r);
            Assert.AreEqual(113.040, res);
        }
    }
}

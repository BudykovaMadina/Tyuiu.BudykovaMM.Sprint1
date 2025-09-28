using Tyuiu.BudykovaMM.Sprint1.Task3.V13.Lib;
namespace Tyuiu.BudykovaMM.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 123;
            double wait = 6.000;
            var res = ds.MultiplyOfDigits(x);
            Assert.AreEqual(wait, res);
        }
    }
}

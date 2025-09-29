using Tyuiu.BudykovaMM.Sprint1.Task6.V2.Lib;
namespace Tyuiu.BudykovaMM.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            
            Assert.IsTrue(ds.CheckHello("Hello world"));
            Assert.IsTrue(ds.CheckHello("Say Hello to everyone"));

            
            Assert.IsFalse(ds.CheckHello("здесь нет нужного слова"));
         
            Assert.IsFalse(ds.CheckHello(""));
        }

    }
}

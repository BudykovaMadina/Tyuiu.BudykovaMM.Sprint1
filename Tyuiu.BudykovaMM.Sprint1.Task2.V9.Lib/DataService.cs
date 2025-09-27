using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BudykovaMM.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            double volume = (4.0 / 3.0) * 3.14 * r * r * r;
            return Math.Round(volume, 3);
        }
    }
}

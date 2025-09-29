using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BudykovaMM.Sprint1.Task7.V6.Lib

{
    public class DataService : ISprint1Task7V6
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round((Math.Pow((1 + 1 / Math.Pow(x, 2)), x) - 12 * Math.Pow(x, 2) * y),3) ;
            return res;
        }
    }
}

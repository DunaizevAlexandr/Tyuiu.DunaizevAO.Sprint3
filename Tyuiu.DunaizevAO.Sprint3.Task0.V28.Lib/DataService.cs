using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DunaizevAO.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                p *= (((Math.Pow(value, 3) * i)) + 2);
            }
            return Math.Round(p, 3);
        }
    }
}

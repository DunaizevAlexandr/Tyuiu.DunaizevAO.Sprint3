using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DunaizevAO.Sprint3.Task2.V25.Lib
{
    public class DataService : ISprint3Task2V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            do
            {
                double chis = Math.Pow(4 / Math.Pow(startValue, value), 2);
                sum += chis;
                startValue++;
            } while (startValue < stopValue);
            return Math.Round(sum,3);
        }
    }
}

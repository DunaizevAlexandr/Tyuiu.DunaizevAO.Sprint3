using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DunaizevAO.Sprint3.Task1.V2.Lib
{
    public class DataService : ISprint3Task1V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            int i = startValue;
            double s = 0;
            while (i <= stopValue)
            {
                s += (Math.Sin(i) * 0.5);
                i++;
            }
            return Math.Round(s, 3);
        }
    }
}

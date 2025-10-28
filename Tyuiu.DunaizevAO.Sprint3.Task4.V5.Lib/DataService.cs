using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DunaizevAO.Sprint3.Task4.V5.Lib
{
    public class DataService : ISprint3Task4V5
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x < stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                double y = (Math.Cos(x) - Math.Sin(x))/x;
                res += y;
            }
            return Math.Round(res,3);
        }
    }
}

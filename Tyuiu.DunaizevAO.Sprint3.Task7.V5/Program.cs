using Tyuiu.DunaizevAO.Sprint3.Task7.V5.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");


int startValue = -5;

int stopValue = 5;

Console.WriteLine("Старт шага: " + startValue);
Console.WriteLine("Конец шага: " + stopValue);


int len = ds.GetMassFunction(startValue, stopValue).Length;
double[] res = new double[len];

res = ds.GetMassFunction(startValue, stopValue);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("+----------+----------+");
Console.WriteLine("|    x     |   f(x)   |");
Console.WriteLine("+----------+----------+");
for (int i = 0; i < len; i++)
{
    Console.WriteLine("|{0,5:d}     |  {1,5:f2}   |", startValue, res[i]);
}
Console.WriteLine("+----------+----------+");

Console.ReadLine();
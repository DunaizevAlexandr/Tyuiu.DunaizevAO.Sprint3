using Tyuiu.DunaizevAO.Sprint3.Task5.V16.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int x = 2;

int startValue1 = 1;

int stopValue1 = 3;

int startValue2 = 1;

int stopValue2 = 10;

Console.WriteLine("X: " + x);
Console.WriteLine("Старт шага I: " + startValue1);
Console.WriteLine("Конец шага I: " + stopValue1);
Console.WriteLine("Старт шага K: " + startValue2);
Console.WriteLine("Конец шага K: " + stopValue2);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2,stopValue2));

Console.ReadLine();
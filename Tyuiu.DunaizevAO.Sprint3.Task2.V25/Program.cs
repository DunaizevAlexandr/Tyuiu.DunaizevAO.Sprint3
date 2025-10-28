using Tyuiu.DunaizevAO.Sprint3.Task2.V25.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int value = 5;

int startValue = 1;

int stopValue = 13;

Console.WriteLine("n равен: " + value);
Console.WriteLine("Старт шага K: " + startValue);
Console.WriteLine("Конец шага K: " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));

Console.ReadLine();
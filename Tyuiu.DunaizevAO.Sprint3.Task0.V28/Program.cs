using Tyuiu.DunaizevAO.Sprint3.Task0.V28.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

double value = 0.25;

int startValue = 1;

int stopValue = 17;


Console.WriteLine("Переменная X: " + value);
Console.WriteLine("Старт шага I: " + startValue);
Console.WriteLine("Конец шага I: " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));

Console.ReadLine();
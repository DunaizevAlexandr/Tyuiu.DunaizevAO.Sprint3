using Tyuiu.DunaizevAO.Sprint3.Task1.V2.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");



int startValue = 1;

int stopValue = 15;


Console.WriteLine("Старт шага I: " + startValue);
Console.WriteLine("Конец шага I: " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.GetSumSeries(startValue, stopValue));

Console.ReadLine();
using Tyuiu.DunaizevAO.Sprint3.Task6.V3.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");


int startValue = 13;

int stopValue = 19;


Console.WriteLine("Старт шага: " + startValue);
Console.WriteLine("Конец шага: " + stopValue);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));

Console.ReadLine();
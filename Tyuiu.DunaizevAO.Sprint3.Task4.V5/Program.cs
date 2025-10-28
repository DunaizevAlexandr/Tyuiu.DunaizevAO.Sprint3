using Tyuiu.DunaizevAO.Sprint3.Task4.V5.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int startValue = -5;

int stopValue = 5;

Console.WriteLine("Первое значение: " + startValue);
Console.WriteLine("Вторрое значение: " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(startValue, stopValue));

Console.ReadLine();
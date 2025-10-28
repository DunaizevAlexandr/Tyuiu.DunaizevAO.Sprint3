using Tyuiu.DunaizevAO.Sprint3.Task3.V21.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

string value = "f3g5ht g4j 34kg4";
char item = 'e';

Console.WriteLine("Строка: " + value);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.ReplaceNumOnChar(value, item));

Console.ReadLine();
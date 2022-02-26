Console.Write("Введите температуру в градусах Фаренгейта: ");

var degF = double.Parse(Console.ReadLine()!);

//var degC = (degF - 32) * 5 / 9;
var degC = ((double) 5) /9 * (degF - 32);
//var degC = 5.0 / 9.0 * (degF - 32.0);
Console.WriteLine($"Температура в градусах Цельсия: {degC:0.00}");


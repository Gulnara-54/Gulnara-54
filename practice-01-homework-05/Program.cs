Console.Write("Введите значение стороны a: ");
var a = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение стороны b: ");
var b = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение стороны c: ");
var c = int.Parse(Console.ReadLine()!);

var V = a * b * c;
Console.WriteLine($"Объем параллелепипеда {a}*{b}*{c} равен {V}");

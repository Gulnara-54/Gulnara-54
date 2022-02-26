Console.Write("Введите минимальное значение: ");
var min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное значение: ");
var max = int.Parse(Console.ReadLine()!);
var res = new Random().Next(min, max + 1);
Console.WriteLine($"Случайно число от {min} до {max}: {res} ");



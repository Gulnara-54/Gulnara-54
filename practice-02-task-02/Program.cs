Console.Write("Введите первое значение:");
var a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе значение:");
var b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Состояние памяти до перестановки: a = {a}; b = {b};");

a += b; //a = a + b;
b = a - b;
a -= b; //a = a - b;

Console.WriteLine($"Состояние памяти после перестановки: a = {a}; b = {b};");


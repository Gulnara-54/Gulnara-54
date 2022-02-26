Console.WriteLine(" a   a ^2   a^3");
Console.Write("Введите число: ");
var number = double.Parse(Console.ReadLine()!);

double result = Math.Pow(number, 2);
Console.WriteLine($"{number} ^ {2} = {result}");

result = Math.Pow(number, 3);
Console.Write($"{number} ^ {3} = {result}"); 











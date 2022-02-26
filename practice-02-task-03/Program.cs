Console.Write("Введите число: ");
var num = int.Parse(Console.ReadLine()!);

num += num % 2; //num + num % 2;

Console.WriteLine(num);


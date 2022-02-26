Console.Write("Введите первое число: ");
long number1 = long.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
long number2 = long.Parse(Console.ReadLine()!);

long sum = number1 + number2;
Console.WriteLine(number1 + " + " + number2 + " = " + sum);
Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
Console.WriteLine($"{number1} + {number2} = {sum}");


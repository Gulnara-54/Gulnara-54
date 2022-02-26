Console.Write("Введите первое число: ");
var number1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
var number2 = double.Parse(Console.ReadLine()!);

//double sum = number1 + number2;
double result = number1 + number2;
//Console.WriteLine(number1 + " + " + number2 + " = " + sum);
//Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
Console.WriteLine($"{number1} + {number2} = {result}");

result = number1 - number2;
Console.WriteLine($"{number1} - {number2} = {result}");

result = number1 * number2;
Console.WriteLine($"{number1} * {number2} = {result}");

result = number1 / number2;
Console.WriteLine($"{number1} / {number2} = {result}");

result = number1 % number2;
Console.WriteLine($"{number1} % {number2} = {result}");

result = Math.Pow(number1, number2);
Console.WriteLine($"{number1} ** {number2} = {result}");
 


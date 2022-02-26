Console.Write("Введите значение в футах: ");
var LengFt = double.Parse(Console.ReadLine()!);

var value = LengFt * (double)0.305m;
Console.WriteLine($"{LengFt:0.00} ft = {value} m");
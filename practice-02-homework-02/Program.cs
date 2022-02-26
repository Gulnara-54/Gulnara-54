Console.Write("Введите радиус и длину цилиндра: ");
var radius = double.Parse(Console.ReadLine()!);
var height= double.Parse(Console.ReadLine()!);

var Sq = radius * radius * Math.PI;
var V = Sq * height; 

Console.WriteLine($"Площадь равна {Sq}");
Console.WriteLine($"Объем равен {V}");

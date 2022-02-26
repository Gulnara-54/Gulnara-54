string? name;
Console.Write("Как вас зовут? ");
name = Console.ReadLine();
//Вариант №1
//Console.WriteLine("Привет, " + name + "!");
// Вариант №2
//Console.WriteLine("Привет, {0}!", name);
//Вариант №3
Console.WriteLine($"Привет, {name}!");
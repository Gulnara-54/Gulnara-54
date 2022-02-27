using System; 

class URI 
{
    static void Main(string[] args)
    { 
        Console.Write("Enter the first value: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the second value: ");
        int b =  int.Parse(Console.ReadLine()!);
        int X = a + b;
        
        
        Console.WriteLine($"X = {a + b}");
        
        
        
    }

}

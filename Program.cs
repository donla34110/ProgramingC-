using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine()?? "0");
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine()?? "0");
        int sum = num1 + num2;
        Console.WriteLine("Sum: " + sum);
    }
}

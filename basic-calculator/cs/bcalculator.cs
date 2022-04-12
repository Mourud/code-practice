using System;

class BCalculator{
    static void Main(){
        Console.WriteLine("Enter an integer: ");
        double num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter another integer: ");
        double num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
    }

}


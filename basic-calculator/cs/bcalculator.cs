using System;

class BCalculator{
    static void Main(){
        Console.WriteLine("Enter an integer: ");
        double num1;
        Double.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Enter another integer: ");
        double num2;
        Double.TryParse(Console.ReadLine(), out num2);

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
    }

}


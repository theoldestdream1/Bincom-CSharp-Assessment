//Task 1: Declare and Initialize Variables

using System;

class Program 
{
    static void Main(string [] args)
    {
        
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        Console.WriteLine("Task 1: Variables");
        Console.WriteLine($"{name}, {age}, {isAdmin}");
    


//Task 2: Check whether a number is even or odd

        Console.WriteLine("\nTask 2: Even or Odd");
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }

// Task 3: Print out the numbers 1 to 10 using a for loop.
        Console.WriteLine("\nTask 3: Print Numbers 1 to 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

// Task 4: Declare and initialize an integer array with the values 2, 4, 6, 8, 10.
        Console.WriteLine("\nTask 4: Integer Array");
        int[] numbers = { 2, 4, 6, 8, 10 };

        int sum = 0;
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
            sum += n;
        }

        Console.WriteLine("Sum: " + sum);

// Task 5: Greet Method

        Console.WriteLine ("\nTask 5: Greeting");

                Greet("Alice");

    }

    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}
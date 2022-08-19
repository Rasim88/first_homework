// Задача 1
    Console.WriteLine("Enter two numbers:");
    int NumberFirst = Convert.ToInt32(Console.ReadLine());
    int NumberSecond = Convert.ToInt32(Console.ReadLine());
    if (NumberFirst > NumberSecond)
    {
        Console.WriteLine("Max Number: " + NumberFirst);
    }
    else if (NumberFirst < NumberSecond)
    {
        Console.WriteLine("Max Number: " + NumberSecond);
    }
    else
    {
        Console.WriteLine("The numbers are equal!");
    }

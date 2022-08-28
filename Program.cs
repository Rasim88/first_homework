// Задачи 10 и 13
Console.WriteLine("Enter any number from 0 to 999:");
int AnyNumber = Convert.ToInt32(Console.ReadLine());

    if (AnyNumber <= 9)
    {
        Console.WriteLine("This is a single digit number: " + AnyNumber);
    }
    else if (AnyNumber > 9 && AnyNumber < 100)
    {
        Console.WriteLine("Second digit: " + (AnyNumber % 10));
        Console.WriteLine("Third digit is missing");
    }
    else if (AnyNumber >= 100)
    {
        Console.WriteLine("Second digit: " + ((AnyNumber / 10) % 10));
        Console.WriteLine("Third digit:" + (10 - (AnyNumber - (AnyNumber / 10) % 10)));
    }
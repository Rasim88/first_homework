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
    
// Задача 2
Console.WriteLine("Enter three numbers:");
int Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = Convert.ToInt32(Console.ReadLine());
int Number3 = Convert.ToInt32(Console.ReadLine());
    if (Number1 > Number2 && Number1 > Number3)
    {
        Console.WriteLine("Max Number: " + Number1);
    }
    else if (Number1 < Number2 && Number1 > Number3)
    {
        Console.WriteLine("Max Number: " + Number2);
    }
    else if (Number1 < Number2 && Number2 < Number3)
    {
        Console.WriteLine("Max Number: " + Number3);
    }
    else if (Number1 == Number2 && Number1 == Number3)
    {
        Console.WriteLine("The three numbers are equal!");
    }

// Задача 4
Console.WriteLine("Enter N number:");
int NumberN = Convert.ToInt32( Console.ReadLine());
for (int i = 1; i <= NumberN; i += 1)
{
if (i % 2 == 0)
Console.WriteLine("An even numbers: " + i);
}
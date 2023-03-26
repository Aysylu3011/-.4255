string? numline1 = Console.ReadLine();
string? numline2 = Console.ReadLine();
if (numline1 != null && numline2 != null)
{
    int num1 = int.Parse(numline1);
    int num2 = int.Parse(numline2);
    if (num1 == num2 * num2)
    {
        Console.WriteLine("да, является.");
    }

    else
    {
        Console.WriteLine("Нет, не является");
    }
}


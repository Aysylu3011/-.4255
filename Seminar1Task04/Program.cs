Console.WriteLine("Введите число трехзначное: ");
string? numline = Console.ReadLine();
if (numline != null)
{
    int num = int.Parse(numline);
    int result = num % 10;
    Console.WriteLine(result);
}
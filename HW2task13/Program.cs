int Num = int.Parse(Console.ReadLine()??"0");
int thirdNum = 0;
if (Num > 100)
{
    while (Num > 100)
    {
        thirdNum = Num % 10;
        Num = Num / 10;
    }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
    
Console.WriteLine(thirdNum);
int Num = int.Parse(Console.ReadLine()??"0");
int secondNum = 0;
while (Num > 10)
{
    secondNum = Num % 10;
    Num = Num / 10;
    
}
Console.WriteLine(secondNum);

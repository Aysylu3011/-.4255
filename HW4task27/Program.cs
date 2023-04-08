int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

int sumOfNum(int num)
{
    int summa = 0;
    char [] digits = num.ToString().ToCharArray();
    int count = digits.Length;
    while(count > 0)
    {
        summa = summa + (num % 10);
        num = num / 10;
        count = count -1;
    }
    return summa;

}

int numberA = ReadData("Введите число: ");
Console.WriteLine("Сумма всех цифр числа: " + sumOfNum(numberA));

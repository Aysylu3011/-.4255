int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

int SumDigitRec(int num)
{
    if (num > 0)
    {
        return num % 10 + SumDigitRec(num/10); 
    }
    else
    {
        return 0;
    }

}

int num = ReadData("Enter num: ");
int sum = SumDigitRec(num);
Console.WriteLine(sum);


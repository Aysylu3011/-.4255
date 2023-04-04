int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

// метод вывода данных

void printResult(string msg, int res)
{
    Console.WriteLine(msg + res);
}

long SumSimple(int numA)
{
    long sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum += i;
    }

    return sum;
}

int numberA = ReadData(" Enter number A: ");
long res1 = SumSimple(numberA);
printResult("Сумма чисел от 1 до A(простой метод): ", (int)res1);
DateTime d1 = DateTime.Now;
Console.WriteLine(DateTime.Now - d1);


// формула Гаусса

long SumGauss(int numA)
{
    return((1+(long)numA) * (long)numA) / 2;
}

printResult("Сумма чисел от 1 до A(метод Гаусса): ", (int)res1);

DateTime d2 = DateTime.Now;
Console.WriteLine(DateTime.Now - d2);
 
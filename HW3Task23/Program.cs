// Подается число, нужно вывести таблицу кубов от 1 до введенного числа

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

string LineGenerator(int num, int pow)
{
    string res = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}

int number = ReadData("ВВедите число: ");
Console.WriteLine(LineGenerator(number, 1));
Console.WriteLine(LineGenerator(number, 3));
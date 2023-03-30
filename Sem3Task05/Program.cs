int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}


string LineGenerator(int num, int pow)
{
    string res = " ";
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + " ";
    }
    return res;
}

int num = ReadData("Enter number");
Console.WriteLine(LineGenerator(5, 1));
Console.WriteLine(LineGenerator(5, 2));










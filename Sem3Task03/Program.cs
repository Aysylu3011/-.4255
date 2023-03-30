int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}



void PrintAnswear(int quater)
{
    if (quater == 1) Console.WriteLine("x > 0, y > 0");
    if (quater == 2) Console.WriteLine("x > 0, y < 0");
    if (quater == 3) Console.WriteLine("x < 0, y < 0");
    if (quater == 4) Console.WriteLine("x < 0, y > 0");
}

int quater = ReadData("Введите номер в четверти");

PrintAnswear(quater);

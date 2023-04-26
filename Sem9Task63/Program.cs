// все нат числа от n до 1

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

void LineGenRec(int numN)
{
    Console.WriteLine(numN + " ");
    if (numN <= 1)
    {

    }
    else
    {
        LineGenRec(numN - 1);
    }


}

int num  = ReadData("ВВедите число: ");
LineGenRec(num);
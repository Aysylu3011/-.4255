int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

long PovNum(int numA, int numB)
{

    if (numB > 0)
    {
        return numA*PovNum(numA, numB - 1);
    }
    else
    {
        return 1;
    }   

}

// long MyPovNum(int numA, int numB)
// {
//     if ()
// }

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
long powOfNumbers = PovNum(numA, numB);
Console.Write(powOfNumbers);
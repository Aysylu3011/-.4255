
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

string RecMN(int numM, int numN)
{
    if (numM <= numN)
    {
        //RecMN(numM + 1, numN);
        return numM + " " + RecMN(numM + 1, numN);

    }
    else
    {
        return;   // string.Empty;
        break;
    }
}

int numM = ReadData("ВВедите число numM: ");
int numN = ReadData("ВВедите число numN: ");
RecMN((numM > numN) ? numN : numM, (numM < numN) ? numM : numN);
//RecMN(numM, numN);

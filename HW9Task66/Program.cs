// Задайте  значения M, N. Напишите программу, находящую сумму натуральных элементов 
// в промежутке от M до N (включительно)
// программа для чтения данных, введенных пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}


// программа для прдсчета суммы элементов между 2 числами
int SumNumRec(int numM, int numN)
{
    if (numM <= numN)
    {
        return numM + SumNumRec(numM + 1, numN); 
    }
    else
    {
        return 0;
    }

}


int numM  = ReadData("ВВедите число M: ");
int numN  = ReadData("ВВедите число N: ");
int suMN = SumNumRec((numM > numN) ? numN : numM, (numM < numN) ? numM : numM);    // вводим защиту от "дурака"
Console.Write(suMN);
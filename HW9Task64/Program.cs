// Задайте значение N. Напишите программу, выводящую
// все натуральные числа от N до 1 с помощью рукурсии

// программа для чтения данных, введенных пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

// программа для вывода натуральных чисел от введенного числа до 1

void LineGenRec(int numN)
{
    Console.Write(numN + " ");
    if (numN <= 1)      // условие для выхода из рекурсии
    {

    }
    else
    {
        LineGenRec(numN - 1);
    }


}

int num  = ReadData("ВВедите число: ");
LineGenRec(num);

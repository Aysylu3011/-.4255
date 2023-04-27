// вычислить функцию Аккермана с помощью рекурсии для 2 неотрицательных чисел

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

// функция Аккермана

int MyAccfunc(int m, int n)
{
                          
  if (m == 0) return n + 1;
                          
  if (m > 0 && n == 0) return MyAccfunc(m - 1, 1);
                          
  else return MyAccfunc(m - 1, MyAccfunc(m, n - 1));
                          
}


int numN  = ReadData("ВВедите число N: ");
int numM  = ReadData("ВВедите число M: ");
int accMN = MyAccfunc(numN, numM);   
Console.Write(accMN);
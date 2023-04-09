// Одномерный массив, найти сумму элементов на нечетной позиции

int[] Gen1DArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}

// печать массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int SumOfElementsOddIndex(int[] arr)
{
    int sumOdd = 0;                             // сумма нечетных чисел
    for (int i = 0; i < arr.Length; i++)        // цикл, который проходит по нечетным индексам массива
    {
        if(i % 2 != 0)
        {
            sumOdd = sumOdd + arr[i];
        }
        else
        {
            continue;
        }
    }
   
      
return sumOdd;
}


int[] arr = Gen1DArray(9, 1, 99);
Print1DArr(arr);
Console.WriteLine(SumOfElementsOddIndex(arr));
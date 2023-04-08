// найти сумму отризательных и сумму положительных чисел в массиве.
// метод создания массива
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue,  maxValue + 1);
    }
    return arr;
}

// метод печати массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i <arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
(int positivenum, int negativenum) DiffSum(int [] arr)
{
    int posSum = 0;
    int negSum = 0;
    for(int i = 0; i <arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            posSum += arr[i];
        }
        else
        {
            negSum += arr[i];
        }
    }
    return(posSum, negSum);
}

int [] arr = Gen1DArray(12, -9, 9);
Print1DArr(arr);
(int positivenum, int negativenum) sum = DiffSum(arr);
Console.WriteLine("Сумма позитивных чисел: " + sum.positivenum);
Console.WriteLine("Сумма отрицательных чисел: " + sum.negativenum);



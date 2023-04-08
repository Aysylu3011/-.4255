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

// метод печати массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
void InversArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);
    }
}
int[] arrnum = Gen1DArray(12, -15, 15);
Print1DArr(arrnum);
InversArr(arrnum);
Print1DArr(arrnum);

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

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

int[] ConvertArray(int[] arr)
{

    int len = (arr.Length % 2 == 0) ? arr.Length / 2 : (arr.Length / 2) + 1;
    int[] outArr = new int[len];

    for (int i = 0; i < len; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }

    return outArr;
}

int[] arrTest = Gen1DArray(7, 4, 20);
Print1DArr(arrTest);
Print1DArr(ConvertArray(arrTest));
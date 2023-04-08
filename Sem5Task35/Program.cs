
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

// метод поиска 2-значных чисел

int ElemInRange(int[] arr, int min, int max)
{
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > min && arr[i] < max)
        {
            res ++;
        }


    }

return res;
}

int[] arr =  Gen1DArray(123, 0, 1000);
Print1DArr(arr);
int res = ElemInRange(arr, 10, 99);
Console.WriteLine("Требуемых элементов: " + res);








// метод, который запрашивает данные у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

// метод генерации массива
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

void SearchElInArray(int num, int[] arr)
{
    bool elemFind = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
        {
            Console.WriteLine("Элемент найден, ячейка: " + i);
            elemFind = true;
        }
    }
    if (elemFind == false)
    {
         Console.WriteLine("Элемент не найден");
    }
}




int[] arr = Gen1DArray(12, -9, 9);
Print1DArr(arr);
int number = ReadData("Enter number: ");
SearchElInArray(number, arr);






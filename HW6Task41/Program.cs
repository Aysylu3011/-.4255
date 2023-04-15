// метод, который запрашивает данные у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

// печать массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ";");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] InputArray( int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadData($"Введите {i + 1}-й элемент");
        
    }
    return array;
}

int CountPositiveNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
        else
        {
            continue;
        }
    }
    return count;
}
 int lenArr = ReadData("Введите количество элементов");
 int[] array = InputArray(lenArr);
 Print1DArr(array);
 Console.WriteLine("Количество чисел больше 0: " + CountPositiveNum(array));

// задайте массив заполненный случайными положительными трехзначными числами
// Var1
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

// Напишите программу, которая покажет количество четных чисел в массиве
int EvenNumAmount(int[] arr)    // задаем массив интеджер
{
    int count = 0;               // счетчик четных чисел
    for (int i = 0; i < arr.Length; i++)     // цикл, который проходит по всему массиву
    {
        if (arr[i] % 2 == 0)                      // условие, в котором отбираются четные числа
        {
            count++;
        }
        else
        {
            continue;                      // если число нечетное, просто продолжаем цикл
        }
    }

    return count;
}

int[] arr = Gen1DArray(14, 100, 999);
Print1DArr(arr);
Console.WriteLine(EvenNumAmount(arr));


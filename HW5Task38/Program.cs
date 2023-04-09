// Массив вещественных чисел. Найти разницу между амксимальным и минимальным значениями элементов массива
double[] Gen1DMassive(int len, int minValue, int maxValue)
{
    double[] arr = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue) + rnd.NextDouble();

    }

    return arr;
}


double DiffOfNum(double[] arr)                               // пишем метод для разницы между минимальным и максимальным элементом
{
    double max = arr[0];                                        // задаем переменные, в которые запишутся минимальное и максимальное значение
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)                 // в цикле перебираем каждый элемент массива
    {
        if (arr[i] > max)                         // сравниваем и записываем в переменную максимальное значение
        {
            max = arr[i];
        }

        if (arr[i] < min)
        {
            min = arr[i];
        }
        else
        {
            continue;
        }
    }

    double result = max - min;        // находим разницу между минимальным и максимальным значением
    return Math.Round(result, 2);                                                 // возвращаем округленное значение 
}


// печать массива
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ";");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double[] arr = Gen1DMassive(5, 2, 3);
Print1DArr(arr);
Console.WriteLine("Разница между минималным и максимальным значением: " +  DiffOfNum(arr));


// Var2, сортировка методом вставки
void InsertSort(double[] arr)      // создаем новый метод сортировки
{
    for (int i = 1; i < arr.Length; i++)   // в цикле проходим по всем элементам массива, начиная с 1 индекса (нулевой индекс считается отсотированным)
    {
        double current = arr[i];          // создаем переменную, в уоторую положим значение 1-го индекса
        int nexty = i;                     // создаем переменную, в которую кладем индекс
        while(nexty > 0 && current < arr[nexty -1])  // в цикле, пока индекс больше 0 и значение в индексе меньше следующего значения
        {
            arr[nexty] = arr[nexty -1]; // меняем местами значения в индексах
            nexty--;                    // переходим к следующему индексу
        }
        arr[nexty] = current;   // присваиваем индексу отсортированное меньшее значение
    }
}
InsertSort(arr);
Print1DArr(arr);

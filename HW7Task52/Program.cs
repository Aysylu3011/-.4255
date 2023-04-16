// двухмерный массив из целых чисел. вывести среднее арифметическое элементов в каждом стодбце

// метод чтения вводимых данных пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

// генерация 2мерного массива
int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(minValue, maxValue + 1);
        }

    }
    return arr;
}

// метод печати 2мерного массива
void Print2DArray(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();

    }
}

// метод печати 1мерного массива
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ";");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double[] MeanOffColumns(int[,] array)
{
    double[] mean = new double[array.GetLength(1)];           // создаем новый одномерный массив, в который будем складывать mean

    for (int j = 0; j < array.GetLength(1); j++)              // цикл по столбцам
    {
        for (int i = 0; i < array.GetLength(0); i++)          // цикл по строкам
        {
            mean[j] += array[i, j];                           // складываем значения в столбцах и добавляем сумму в одномерный массив

        }
        mean[j] = mean[j] / array.GetLength(0);               // делим сумму на количество элементов в столбце
    }

    return mean;                                            
}


// метод округления значений в вещественном одномерном массиве
void RoundMethod(double[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i], 2);
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("ВВедите коичество столбцов: ");
int[,] arr2D = Gen2DArray(row, column, 2, 20);
Print2DArray(arr2D);
double[] arr = MeanOffColumns(arr2D);
RoundMethod(arr);
Print1DArr(arr);







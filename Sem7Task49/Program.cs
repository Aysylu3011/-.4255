// массив, у которого значения в четных индексах заменены на квадраты
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
void UpdateSqrtIndexArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < array.GetLength(1); j = j + 2)
        {

            array[i, j] = array[i, j] * array[i, j];
        }
    }
}
int row = ReadData("ВВедите количество строк: ");
int column = ReadData("ВВедите количество столбцов: ");
int[,] arr2D = Gen2DArray(row, column, 10, 99);
Print2DArray(arr2D);
UpdateSqrtIndexArray(arr2D);
Print2DArray(arr2D);

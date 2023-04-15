// таблица со случайными числами 
// метод, который запрашивает данные у пользователя
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

// печать массива 2d

void Print2DArray(int[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <  arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();

    }
}
 
int row = ReadData("ВВедите количество строк: ");
int column = ReadData("ВВедите количество столбцов: ");
int [,] arr2D = Gen2DArray(row, column, 10, 99);
Print2DArray(arr2D);

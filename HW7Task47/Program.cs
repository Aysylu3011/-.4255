// Задайте двухмерный массив размером m*n, заполненный случайными вещественными числами
// * каждую цифру показать разного цвета - к сожалению, не могу выполнить это задание.

// метод считывающий вводимые данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

// генерация 2мерного массива
double[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(minValue, maxValue + 1) + rnd.NextDouble();
        }

    }
    return arr;
}

// метод для округления  до 2 знаков после зяпятой
void RoundMethod(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
}

// печать 2мерного массива
void Print2DArray(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan,
                                            ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow,
                                            ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();

    }
}


int row = ReadData("ВВедите количество строк: ");
int column = ReadData("ВВедите количество столбцов: ");
double[,] arr2D = Gen2DArray(row, column, 10, 99);
RoundMethod(arr2D);
Print2DArray(arr2D);

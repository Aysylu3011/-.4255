// Программа, принимающая позиции элемента в 2мерном массиве и возвращающая либо значение 
// этого элемента, либо указание на его отсутствие

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
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,
                                            ConsoleColor.DarkGray,ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,ConsoleColor.DarkYellow,
                                            ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};
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

int row = ReadData("Введите количество строк: ");
int column = ReadData("ВВедите коичество столбцов: ");
int rowIndex = ReadData("Введите индекс строки (индексация с 0): ");        // запрашиваем у пользователя индекс строки
int columnIndex = ReadData("ВВедите индекс столбца(индексация с 0): ");     // запрашиваем у пользователя индекс столбцов

void FindValue(int[,] array)
{
    if (rowIndex > array.GetLength(0) || columnIndex > array.GetLength(1))      // проверяем наличие введенных индексов
    {
        Console.WriteLine("Таких индексов не существует");
    }
    else
    {

        Console.WriteLine(array[rowIndex, columnIndex]);                        // выводим значение индексов
    }
}


int[,] arr2D = Gen2DArray(row, column, 10, 99);
Print2DArray(arr2D);
FindValue(arr2D);

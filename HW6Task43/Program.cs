// напишите программу, которая найдет точку пересечения 2 прямых, заданных
// уравнениями y = k1*x + b1, y = k2*x + b2, все значения, кроме x задаются пользователем.

// метод, который запрашивает данные у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 1;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] LineData1 = InputLineData(LINE1);
double[] LineData2 = InputLineData(LINE2);

if(ValidDateLines(LineData1, LineData2))
{
    double[] coord = FindCoords(LineData1, LineData2);
    Console.Write($"Точка пересечения уравнений y = {LineData1[COEFFICIENT] * x + LineData1[CONSTANT]} и y = {LineData2[COEFFICIENT] * x + LineData2[CONSTANT]}");
    Console.WriteLine($"имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");

}

double[] InputLineData(int numOfLine)
{
    double[] LineData = new dooble[2];
    LineData[COEFFICIENT] = ReadData($"Введите коэффициент для {numOfLine} прямой");
    LineData[CONSTANT] = ReadData($"Введите коэффициент для {numOfLine} прямой");
    return LineData;
}

double[] FindCoords(double[] LineData1, double[] LineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (LineData1[CONSTANT] - LineData2[CONSTANT]) / (LineData2[COEFFICIENT] - LineData1[COEFFICIENT]);
    coord[Y_COORD] = LineData1[CONSTANT] * coord[X_COORD] + LineData1[CONSTANT];
    return coord;
}

bool ValidDateLines(double[] LineData1, double[] LineData2)
{
    if(LineData1[COEFFICIENT] == LineData2[COEFFICIENT])
    {
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
    
    return true;
}

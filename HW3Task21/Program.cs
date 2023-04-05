// На вход подаются координаты двух точек. Нужно найти растояние между ними (3D пространство)

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}

double CalcLen3D(int x1, int x2, int y1, int y2, int d1, int d2)  // создаем метод, в котором ищем расстояние между точками
{
    return Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (d1 - d2)*(d1 - d2));   // Math.Pov() у мен почему-то не прошел, сделала так

}

int x1 = ReadData("Введите координату по оси икс для точки a: ");
int x2 = ReadData("Введите координату по оси икс для точки Б: ");
int y1 = ReadData("Введите координату по оси игрек для точки a: ");
int y2 = ReadData("Введите координату по оси игрек для точки Б: ");
int d1 = ReadData("Введите координату по оси ди для точки a: ");
int d2 = ReadData("Введите координату по оси ди для точки Б: ");
Console.WriteLine("Расстояние между точками a и Б: " +  CalcLen3D(x1, x2, y1, y2, d1, d2));

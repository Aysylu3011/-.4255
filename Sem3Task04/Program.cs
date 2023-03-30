int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}



double Calclen2D(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + (y1 - y2)*(y1 - y2));
}
int x1 = ReadData("Enter first coord: ");
int x2 = ReadData("Enter first coord: ");
int y1 = ReadData("Enter first coord: ");
int y2 = ReadData("Enter first coord: ");

Console.WriteLine("Расстояние между точками А и Б: " +  Calclen2D(x1, x2, y1, y2));
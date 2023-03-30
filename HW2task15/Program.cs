int Num = int.Parse(Console.ReadLine()??"0");
var weekDays = new Dictionary<int, string>()
{
    {1, "Monday"},
    {2, "Tuesday"},
    {3, "Wednesday"},
    {4, "Thursday"},
    {5, "Friday"},
    {6, "Saturday"},
    {7, "Sunday"}
};
if (Num > 5 && Num < 8)
{
    Console.WriteLine("Это выходной день");
    //Console.WriteLine("For key = \"6\", value = {6}");
   // Console.WriteLine("For key = \"7\", value = {7}");
}
else
{
    Console.WriteLine("Это не выходной день");
}
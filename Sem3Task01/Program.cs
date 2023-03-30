int Num = int.Parse(Console.ReadLine()??"0");
Dictionary<int, string> weekDays = new Dictionary<int, string>();
weekDays.Add(1, "Monday");
weekDays.Add(2, "Tuesday");
weekDays.Add(3, "Wednesday");
weekDays.Add(4, "Thursday");
weekDays.Add(5, "Friday");
weekDays.Add(6, "Saturday");
weekDays.Add(7, "weekDays.AddSunday");

if (weekDays.ContainsKey(Num))
{
    Console.WriteLine(weekDays[Num]);

}
else
{
    Console.WriteLine("Это не выходной день");
}

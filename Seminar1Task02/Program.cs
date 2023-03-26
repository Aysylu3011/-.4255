Console.WriteLine("Введите день недели: ");
string? dayline = Console.ReadLine();
if (dayline != null)
{
    string[] dayWeek = new string[7];
    dayWeek[0] = "monday";
    dayWeek[1] = "tuesday";
    dayWeek[2] = "wednesday";
    dayWeek[3] = "thursday";
    dayWeek[4] = "friday";
    dayWeek[5] = "saturday";
    dayWeek[6] = "sunday";
    int day = int.Parse(dayline);
    Console.WriteLine(dayWeek[day-1]);
}

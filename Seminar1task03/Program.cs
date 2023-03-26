string? numline = Console.ReadLine();
if (numline != null)
{
   int num = int.Parse(numline);
   int startnum = num * -1;
   string result = string.Empty;
   while (startnum <= num)
   {
    result = result + startnum + " ";
    startnum = startnum + 1;
    // startnum ++
   }
   Console.WriteLine(result);
}

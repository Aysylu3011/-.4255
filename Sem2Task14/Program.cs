int num = int.Parse(Console.ReadLine() ?? "0");
bool res1 = (num % 7 == 0);
bool res2 = (num % 23 == 0);
if (res1 && res2)
{
    Console.WriteLine("Число кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно одновременно 7 и 23");

}




int Num1 = int.Parse(Console.ReadLine()??"0");
int Num2 = Convert.ToInt32(Console.ReadLine()); // содержит обработчик ошибок, на ноль проверять не нужно

bool res = (Num1%Num2==0);
if (res)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine("Первое число не кратно второму");
    Console.WriteLine(Num1%Num2);
}

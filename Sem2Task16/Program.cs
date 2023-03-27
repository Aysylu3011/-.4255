int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");
// method
void SqrtTest(int a, int b)
{

    if( a == b*b)
    {
        Console.WriteLine(a + " Квадрат числа " + b);
    }
       
    else
    {
        Console.WriteLine(a + " Не квадрат числа "+ b);
    }

}
SqrtTest(num1, num2);
SqrtTest(num2, num1);
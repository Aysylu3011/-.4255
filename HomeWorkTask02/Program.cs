int numberA = 2,
    numberB = 7,
    numberC = 3;
int max = numberA;
if (numberB > numberA) max = numberB;
else
{
    if (numberA > numberC) max = numberA;
    else
    {
        max = numberC;
        
    }
}
Console.WriteLine(max); 

/// так как задачи однотипные решила придумать общее решение. Оно, конечно
/// только для положительных чисел

string? numline1 = Console.ReadLine(); // считываем число, которое вводит пользователь
string? numline2 = Console.ReadLine();
string? numline3 = Console.ReadLine();
int maximum = 0; // объявляем переменную, в которой будем хранить максимальное число
if (numline1 != null && numline2 != null && numline3 != null) // проверяем, что пользователь не оставил значение пустым
{
    int num1 = int.Parse(numline1); // парсим строку в числа
    int num2 = int.Parse(numline2);
    int num3 = int.Parse(numline3);
        if (num2 > num1) maximum = num2; // сравниваем в условии 2 переменных
    else
    {
        if (num1 > num3) maximum = num1;
        else
        {
            maximum = num3;
        
        }
    }
    
}
Console.WriteLine(maximum); // выводим максимум

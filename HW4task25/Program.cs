// считываем данные спомощью ранее записанной программы
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}
int powOfToNumbers(int numA, int numB)      // создаем метод для возведения первого числа в степень равную второму число
{   
    int result = 1;                         // в этой строке копим умножение числа самого на себя
    int count = 0;                             //  создаем переменную счетчик, которая отвечает за количество (второе число) умножения  первого числа на само себя
    while (count < numB)                    // создаем цикл, который заканчивается тогда, когда счетчик сравняется со вторым числом
    {
        result = result*numA;               // умножаем число на само себя
        count++;                            // увеличиваем счетчик
    }
    return result;
}

int firstNum = ReadData("Введите первое число: ");
int secondNum = ReadData("Введите второе число: ");
Console.WriteLine("Первое число, возведенное в степень второго: " + powOfToNumbers(firstNum, secondNum));

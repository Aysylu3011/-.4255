string? numline = Console.ReadLine(); // считываем число, которое вводит пользователь
if (numline != null) // проверяем, что введено не пустое значение
{
   int num = int.Parse(numline);  //  парсим строку в интеджер
   int startnum = num - (num - 1); // находим стартовое число
   string result = string.Empty;  // создаем пустую строку для накопления чисел
   while (startnum <= num) // цикл от стартового числа до введенного
   {
    if (startnum % 2 == 0) // проверяем четноесть числа
    {
        result = result + startnum + " "; // накапливаем числа в строку
        startnum++; // переходим к следующему числу
    } 
    else // если условие не выполняется, просто переходим к следующему числу
    {
       startnum++; 
    }
        
    }
    Console.WriteLine(result);  // выодим результат 
}


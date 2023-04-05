// напишите программу, которая принимает на вход пятнизначное
// число и проверяе, является ли оно палиандром

// метод для получения данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");

    return res;
}


// метод для проверки поиандра
bool CheckPoliandr(int num)
{
    bool resultCheck = false;      // вводим булеву переменную, ставим флаг false
    string res = string.Empty;    // вводим пустую строку, в которую будем собирать цифры числа
    int digit = 0;               // здесь будем хранить цифры для добавления их в строку
    while (num >= 1)                // в цикле отсоединим каждую цифру от числа и добавим в строку (причем цифры запишутся задом наперед, но нам это не важно)
    {
        digit = num % 10;
        res = res + digit;
        num = num / 10;
    }
    resultCheck = (int)res[0] == (int)res[4] && (int)res[1] == (int)res[3] ? true : false;   // тернарный оператор проверки условия. Если условие соответствует, 
    return resultCheck;                                                                      // меняем флаг с false на true

}


int numer = ReadData("Введите 5-тизначное число: ");
bool res = CheckPoliandr(numer);
Console.WriteLine("Poliandr: " + res);


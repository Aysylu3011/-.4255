System.Random numSintezator = new Random();
// Var 1
int rndNum = numSintezator.Next(10, 100);
Console.WriteLine(rndNum);
short firstNum = (short)(rndNum / 10);
short secondNum = (short)(rndNum % 10);

if (firstNum > secondNum)
{
    Console.WriteLine("Первое число больше " + firstNum + " второго " + secondNum);
} 
else
{
    Console.WriteLine("Второе число больше " + secondNum + " первого " + firstNum);
}

char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
firstNum = (int)(digits[0])-48;
secondNum = (int)(digits[1])-48;
// тернарный оператор
int res = (firstNum>secondNum)?firstNum:secondNum;
Console.WriteLine(res);

// табличные решения
// int rndNumArr = numSintezator.Next(10, 100);
// Console.WriteLine(rndNumArr);
// int[]

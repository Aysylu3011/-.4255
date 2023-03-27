int Num = new Random().Next(100, 1000);
Console.WriteLine(Num);
int firstNum = Num / 100;
int lastNum = Num % 10;
int newNum = (firstNum*10) + lastNum;
Console.WriteLine(newNum);

// 1
int numberA = 5, 
    numberB = 7;
int max = numberA;
if (numberA > numberB) max = numberA;
if (numberA < numberB) max = numberB;
Console.WriteLine(max);

// 2
int numberC = 2, 
    numberD = 10;
int maximum = numberC;
if (numberC > numberD) maximum = numberC;
if (numberC < numberD) maximum = numberD;
Console.WriteLine(maximum);

// 3
int numberE = -9; 
int numberF = -3;
int maxi = numberE;
if (numberE !=  null && numberF != null)
{
    //int numE = int.Parse(numberE);
    //int numF = int.Parse(numberF);
    if (((numberE * -1) + numberF) > 0) maxi = numberF;
    if (((numberE * -1) + numberF) < 0) maxi = numberE;
    Console.WriteLine(maxi);
}

using System;
class Program
{
static void Main(string[] args)
{    
Console.Clear();
int PowerRase(int arg1, int arg2)
{
    if (arg2 < 0) arg2 = arg2 * (-1);
    int result = 1;
    for (int i =0; i < arg2; i++)
    {
        result = result*arg1;
    }
    return result;
}

int Input()
{
    Console.WriteLine("Input number ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int factor = Input();
int exponent = Input();
int degree = PowerRase(factor, exponent);
Console.WriteLine($"{factor} возвести в степень {Math.Abs(exponent)} равно {degree}");
    }
}
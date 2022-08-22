using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите чсло");
        int ostatoc = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (ostatoc > 0)
        {
            count = count + ostatoc % 10;
            ostatoc = (ostatoc - ostatoc % 10) / 10;
        }
        Console.WriteLine("Сумма всех цифр вводимого числа" + count);
    }

}


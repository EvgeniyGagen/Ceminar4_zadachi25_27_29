using System;

double [] Array = new double [10];
for(i = 0; i < Array.Length; i++)
{
     Array[i] = new Random().Next(1, 10);
     Console.Write(Array[i]+ " ");
}
double min = Array[0];
double max = Array[0];
for(i = 1; i < Array.Length; i++)
{
    if(max < Array[i])
{
    max = Array[i];
}
if(min < Array[i])
{
    min = Array[i];
}
}
double razn = max - min;
Console.WriteLine($" Разница между max и min элементом = {razn}");


// using System;
// class Program
// {

// static void Main(string[] args)
// {

// int [] Array = new int [10];
// for(i = 0; i < Array.Length; i++)
// {
//     Array[i] = new Random().Next(1, 10);
//     Console.Write(Array[i]+ " ");
// }
// int min = Array[0];
// int max = Array[0];
// for(i = 1; i < Array.Length; i++)
// {
//     if(max < Array[i])
//     {
//         max = Array[i];
//     }
//     if(min < Array[i])
//     {
//         min = Array[i];
//     }
// }
// int razn = max - min;
// Console.WriteLine($" Разница между max и min элементом = {razn}");
// }
// }

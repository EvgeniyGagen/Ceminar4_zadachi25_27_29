int array = new int[10];
int suma = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i]+ " ");
    if(i%2 == 1)
    {
        suma += array[i];
    }
}
Console.WriteLine($" {suma}");

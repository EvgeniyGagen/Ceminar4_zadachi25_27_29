using System;


class Program
{
    
    static void Main (string[] args)
    {
        int [] numbers = {1, 2, 5, 7, 19};
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write("["+ numbers[i]+  "]"); 
        }
        // string number = Console.ReadLine(); 
        // string[] array = new string[number.Length];
        // int index = 0;
        // foreach (var item in number) 
        // {
        //     if(item != ',')
        //     {
        //         array[index] += item.ToString();
               
        //     }else{ 
        //         index++;
        //     }
        // }
        // Console.Write("[ "); 
        // for(int i = 0; i<=index-1; i++)
        // {
        //     Console.Write(array[i] + ", "); 
        // }
        // Console.Write(array[index] + " ]");
    }
}

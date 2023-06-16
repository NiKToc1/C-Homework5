﻿void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void Quantity(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
            count = count + 1;
        
    }
    Console.WriteLine($"Количество чётных элементов: {count}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Quantity(array);

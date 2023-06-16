void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
}

void Summa(int[] array)
{
    int numberSum = 0; int i = 1;
    while (i < array.Length)
    {
        numberSum = numberSum + array[i];
        i = i + 2;
    }
Console.WriteLine($"Сумма элементов на нечётных позициях: {numberSum}");    
}



Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Summa(array);
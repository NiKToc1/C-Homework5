void InputArray(double[] array)
{
    int end = 100, begin = 0;
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}

void difference(double[] array)
{
    double min = array[0]; double max = array[0]; double diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
        else if (array[i]< min)
        min = array[i];
    }
    diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
difference(array);
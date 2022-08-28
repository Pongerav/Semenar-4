void FillArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


int Chetn(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }
    return result;
}


int NChetn(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1) result += 1;
    }
    return result;
}


Console.WriteLine("Введите длину массива");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];

FillArrayRandom(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"{Chetn(array)} - чётных элементов в массиве  " + $"\n{NChetn(array)} - нечётных элементов в массиве");
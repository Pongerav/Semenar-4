void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i+1}: ");
        array[i] = int.Parse(Console.ReadLine() ?? "0");
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


Console.WriteLine("Введите длину массива");

int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];

FillArray(array);

for (int i = 0; i < length; i++)
{
    array[i] = array[i] * (-1);
}

PrintArray(array);
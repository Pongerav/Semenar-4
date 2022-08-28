void FillArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
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
FillArrayRandom(array);
PrintArray(array);

int sum = 0;

for (int i = 1; i < length; i += 2) sum += array[i];

Console.WriteLine($"\n{sum} - сумма чисел на нечётных позициях");
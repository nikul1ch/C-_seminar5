Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

void FillingArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(100, 1000);
}

int CountingNumberOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 0) count++;
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i]);
        else Console.Write(array[i] + ", ");
    }
    Console.WriteLine(" ]");
}

FillingArrayRandom(arr);
PrintArray(arr);

Console.Write("Количество чётных чисел в массиве: " + CountingNumberOfEven(arr));
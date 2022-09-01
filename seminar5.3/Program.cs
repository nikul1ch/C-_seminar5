Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];

void FillingArrayRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().NextDouble() * 10; //Умножил на 10 для наглядности
}

double MinDigitInArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++) if (min > array[i]) min = array[i];
    return min;
}

double MaxDigitInArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++) if (max < array[i]) max = array[i];
    return max;
}

void PrintArray(double[] array)
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

double min = MinDigitInArray(arr);
double max = MaxDigitInArray(arr);

Console.Write($"Разница между максимальным и минимальным элементов массива = {max - min}");
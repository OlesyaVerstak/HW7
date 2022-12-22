// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
System.Console.WriteLine("DВведите размер массива m*n");
int m = inputNumber("Введите m:");
int n = inputNumber("Введите n:");
double[,] arr = FillArray(m, n);
PrintArray(arr);

double[,] FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.Next(-10, 10)+ rand.NextDouble(), 3);
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}


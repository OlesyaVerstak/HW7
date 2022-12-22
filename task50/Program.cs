// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
System.Console.WriteLine("Введите размер массива m*n");
int m = inputNumber("Введите m:");
int n = inputNumber("Введите n:");
System.Console.WriteLine("Введите позиции элемента массива");
int x = inputNumber("Введите x:");
int y = inputNumber("Введите y:");
int[,] arr = FillArray(m, n);
PrintArray(arr);
ShowElement(arr, x, y);

void ShowElement(int[,] arr, int x, int y)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i = x && j = y)

                Console.WriteLine("Элемент на данной позиции =" + arr[i, j]);

            else
                Console.WriteLine("Такого элемента нет");
        }
    }
    return;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t"); // "\t" - добавляет 4 пробела
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 10);
        }
    }
    return array;
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


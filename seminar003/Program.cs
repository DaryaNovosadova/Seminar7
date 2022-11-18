// Задача49. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты.

Console.WriteLine("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите колличество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] arr = GetArray(rows, columns, 0, 10);
PrintArray(arr);
Console.WriteLine();
PrintArray(TransArr(arr));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] TransArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        if(i % 2 == 0)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if(j % 2 == 0)
                {
                    arr[i, j] = arr[i, j] *arr[i, j];
                }
            }
        }
    }
    return arr;
}